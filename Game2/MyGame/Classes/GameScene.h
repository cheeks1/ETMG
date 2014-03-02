#ifndef __GAME_SCENE_H__
#define __GAME_SCENE_H__

#include "cocos2d.h"
#include "PlayerObject.h"
#include "EnemyObject.h"
#include "Box2D/Box2D.h"
//#include "CMMagnetometer.h"

using namespace cocos2d;

#define NUM_ENEMY 10

class GameScene : public cocos2d::Layer
{
private:
    PlayerObject oPlayer;
    
    b2Body* playerBody;
    
    EnemyObject Enemies[NUM_ENEMY];
    
    bool bIsOver;
    
    bool bIsTouching;
    
    b2World* world;
    
    b2Vec2 gravity;

    
public:
    // there's no 'id' in cpp, so we recommend returning the class instance pointer
    static cocos2d::Scene* createScene();
    
    // Here's a difference. Method 'init' in cocos2d-x returns bool, instead of returning 'id' in cocos2d-iphone
    virtual bool init();
    
    // a selector callback
    void menuCloseCallback(Object* pSender);
    
    // main menu selector callback
    void MainMenuButtonCallback(Object* pSender);
    
    // implement the "static create()" method manually
    CREATE_FUNC(GameScene);
    
    PlayerObject* GetPlayer();
    
    bool GetTouching();
    
    EnemyObject* GetEnemies();
    
    void SetTouching(bool is);

    void CheckCollision();
    
    void GameCondition(bool bCondition);
    
};


#endif // __GAME_SCENE_H__
