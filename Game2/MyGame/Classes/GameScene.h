#ifndef __GAME_SCENE_H__
#define __GAME_SCENE_H__

#include "cocos2d.h"
//#import <CoreMotion/CMMagnetometer.h>

class GameScene : public cocos2d::Layer
{
private:
    
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
};

#endif // __GAME_SCENE_H__
