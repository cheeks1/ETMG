#include "MainMenuScene.h"
#include "SimpleAudioEngine.h"


Scene* MainMenuScene::createScene()
{
    // 'scene' is an autorelease object
    auto scene = Scene::create();
    
    // 'layer' is an autorelease object
    auto layer = MainMenuScene::create();
    
    // add layer as a child to scene
    scene->addChild(layer);
    
    // return the scene
    return scene;
}

// on "init" you need to initialize your instance
bool MainMenuScene::init()
{
    //////////////////////////////
    // 1. super init first
    if ( !Layer::init() )
    {
        return false;
    }
    
    Size visibleSize = Director::getInstance()->getVisibleSize();
    Point origin = Director::getInstance()->getVisibleOrigin();
    
    CocosDenshion::SimpleAudioEngine::getInstance()->playBackgroundMusic("JazzTip.wav");    

    /////////////////////////////
    // 2. add a menu item with "X" image, which is clicked to quit the program
    //    you may modify it.
    
    // add a "close" icon to exit the progress. it's an autorelease object
    auto closeItem = MenuItemImage::create(
                                           "CloseNormal.png",
                                           "CloseSelected.png",
                                           CC_CALLBACK_1(MainMenuScene::menuCloseCallback, this));
    
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
    std::string myString = ("Main Menu");// %f", UIScreen::mainScreen.brightness);
    
    auto label = LabelTTF::create(myString, "Arial", 24);
    
    // position the label on the center of the screen
    label->setPosition(Point(origin.x + visibleSize.width/2,
                             origin.y + visibleSize.height - label->getContentSize().height));
    
    // add the label as a child to this layer
    this->addChild(label, 1);
    
    // add "HelloWorld" splash screen"
    auto sprite = Sprite::create("HelloWorld.png");
    
    // position the sprite on the center of the screen
    sprite->setPosition(Point(visibleSize.width/2 + origin.x, visibleSize.height/2 + origin.y));
    
    // add the sprite as a child to this layer
    this->addChild(sprite, 0);
    
    //Game Button
    auto gameButton = MenuItemImage::create("gameButton.png", "gameButton.png", CC_CALLBACK_1(MainMenuScene::GameButtonCallback, this));
    
    gameButton->setPosition(visibleSize.width/2, visibleSize.height/2 + 75);
    
    auto gameButtonMenu = Menu::create(gameButton, NULL);
    gameButtonMenu->setPosition(Point::ZERO);
    this->addChild(gameButtonMenu, 1);
    
    //Exit Button
    auto exitButton = MenuItemImage::create("exitButton.png", "exitButton.png", CC_CALLBACK_1(MainMenuScene::ExitButtonCallback, this));
    
    exitButton->setPosition(visibleSize.width/2, visibleSize.height/2 - 75);
    
    auto exitButtonMenu = Menu::create(exitButton, NULL);
    exitButtonMenu->setPosition(Point::ZERO);
    this->addChild(exitButtonMenu, 1);
    
    return true;
}


void MainMenuScene::menuCloseCallback(Object* pSender)
{
    Director::getInstance()->end();
    
#if (CC_TARGET_PLATFORM == CC_PLATFORM_IOS)
    exit(0);
#endif
}

void MainMenuScene::ExitButtonCallback(Object* pSender)
{
    Director::getInstance()->end();
    
#if (CC_TARGET_PLATFORM == CC_PLATFORM_IOS)
    exit(0);
#endif
}

void MainMenuScene::GameButtonCallback(Object* pSender)
{
    CocosDenshion::SimpleAudioEngine::getInstance()->stopBackgroundMusic();
    Director::getInstance()->pushScene(GameScene::createScene());
}
