//
//  WinScene.h
//  MyGame
//
//  Created by Timothy Cheek on 3/2/14.
//
//

#ifndef __MyGame__WinScene__
#define __MyGame__WinScene__

#include "cocos2d.h"
#include "MainMenuScene.h"

class WinScene : public cocos2d::Layer
{
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
    CREATE_FUNC(WinScene);
};

#endif /* defined(__MyGame__WinScene__) */
