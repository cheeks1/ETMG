#include "GameScene.h"


USING_NS_CC;

b2World* world;
b2Vec2 gravity;

Scene* GameScene::createScene()
{
    // 'scene' is an autorelease object
    auto scene = Scene::create();
    
    // 'layer' is an autorelease object
    auto layer = GameScene::create();
    
    // add layer as a child to scene
    scene->addChild(layer);
    
    // return the scene
    return scene;
}

// on "init" you need to initialize your instance
bool GameScene::init()
{
    //////////////////////////////
    // 1. super init first
    if ( !Layer::init() )
    {
        return false;
    }
    
    bIsOver = false;
    bIsTouching = false;
    
    this->setColor(cocos2d::Color3B(255, 255, 255));
    
    Size visibleSize = Director::getInstance()->getVisibleSize();
    Point origin = Director::getInstance()->getVisibleOrigin();
    
    
    //CCTouchDispatcher::sharedDispatcher()->addTargetedDelegate(this, 0, true);
    
    /////////////////////////////
    // 2. add a menu item with "X" image, which is clicked to quit the program
    //    you may modify it.
    
    // add a "close" icon to exit the progress. it's an autorelease object
    auto closeItem = MenuItemImage::create(
                                           "CloseNormal.png",
                                           "CloseSelected.png",
                                           CC_CALLBACK_1(GameScene::menuCloseCallback, this));
    
	closeItem->setPosition(Point(origin.x + visibleSize.width - closeItem->getContentSize().width/2 ,
                                 origin.y + closeItem->getContentSize().height/2));
    
    // create menu, it's an autorelease object
    auto menu = Menu::create(closeItem, NULL);
    menu->setPosition(Point::ZERO);
    this->addChild(menu, 1);
    
    /////////////////////////////
    // 3. add your codes below...
    
    // add a label shows "Hello World"
    // create and initialize a label
    
    auto label = LabelTTF::create("Game Scene", "Arial", 24);
    
    // position the label on the center of the screen
    label->setPosition(Point(origin.x + visibleSize.width/2,
                             origin.y + visibleSize.height - label->getContentSize().height));
    
    // add the label as a child to this layer
    this->addChild(label, 1);
    
    // add "HelloWorld" splash screen"
    auto sprite = Sprite::create("Finish.png");
    
    // position the sprite on the center of the screen
    sprite->setPosition(Point(visibleSize.width - 32, visibleSize.height/2 + origin.y));
    
    // add the sprite as a child to this layer
    this->addChild(sprite, 0);
    
    //Main menu Button
    auto mainButton = MenuItemImage::create("mainMenuGameButton.png", "mainMenuGameButton.png", CC_CALLBACK_1(GameScene::MainMenuButtonCallback, this));
    
    mainButton->setPosition(110, visibleSize.height - 60);
    
    auto mainButtonMenu = Menu::create(mainButton, NULL);
    mainButtonMenu->setPosition(Point::ZERO);
    this->addChild(mainButtonMenu, 1);
    
    this->addChild(oPlayer.GetSprite());
    
    auto listener1 = EventListenerTouchOneByOne::create();
    listener1->setSwallowTouches(true);
    
    listener1->onTouchBegan = [](Touch* touch, Event* event){
        // event->getCurrentTarget() returns the *listener's* sceneGraphPriority node.
        auto target = static_cast<GameScene*>(event->getCurrentTarget());
        
        //Get the position of the current point relative to the button
        Point locationInNode = target->convertToNodeSpace(touch->getLocation());
        
        //Check the click area
        if (target->GetPlayer()->GetBounds().containsPoint(locationInNode))
        {
            //target->GetPlayer()->SetPos(locationInNode);
            target->SetTouching(true);
            return true;
        }
        target->SetTouching(false);
        return false;
    };
    
    //Trigger when moving touch
    listener1->onTouchMoved = [](Touch* touch, Event* event){
        auto target = static_cast<GameScene*>(event->getCurrentTarget());
        Point locationInNode = target->convertToNodeSpace(touch->getLocation());
        
        if(target->GetTouching())
        {
            //Move the position of player
            target->GetPlayer()->SetPos(locationInNode);
        }
    };
    
    _eventDispatcher->addEventListenerWithSceneGraphPriority(listener1, this);
    
    //Setting up box2d
    gravity.Set(0.0f, 0.0f);
    world = new b2World(gravity);
    
    
    //Placing Enemies
    for(int i = 0; i < 10; ++i)
    {
        //random y
        int minY = 16;
        int maxY = visibleSize.height - 16;
        int rangeY = maxY - minY;
        int randomY = (arc4random() % rangeY) + minY;
        //random x
        int minX = 100;
        int maxX = visibleSize.width - 50;
        int rangeX = maxX - minX;
        int randomX = (arc4random() % rangeX) + minX;
    
        Enemies[i].SetPos(Point(randomX, randomY));
        this->addChild(Enemies[i].GetSprite());
        
        b2BodyDef enemyBodyDef;
        enemyBodyDef.type = b2_staticBody;
        enemyBodyDef.position = b2Vec2(Enemies[i].GetPos().x, Enemies[i].GetPos().y);
        enemyBodyDef.userData = Enemies[i].GetSprite();
        
        auto enemyBody = world->CreateBody(&enemyBodyDef);
        
        b2CircleShape circle;
        circle.m_radius = 32;
        
        b2FixtureDef enemyFixDef;
        enemyFixDef.shape = &circle;
        enemyFixDef.density = 1.0f;
        
        enemyBody->CreateFixture(&enemyFixDef);
        
    }
    
    return true;
}

PlayerObject* GameScene::GetPlayer()
{
    return &oPlayer;
}

bool GameScene::GetTouching()
{
    return bIsTouching;
}

void GameScene::SetTouching(bool bIs)
{
    bIsTouching = bIs;
}

void GameScene::menuCloseCallback(Object* pSender)
{
    Director::getInstance()->end();
    
#if (CC_TARGET_PLATFORM == CC_PLATFORM_IOS)
    exit(0);
#endif
}

void GameScene::MainMenuButtonCallback(Object* pSender)
{
    Director::getInstance()->popScene();
}

