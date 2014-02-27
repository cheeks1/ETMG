//
//  PlayerObject.h
//  MyGame
//
//  Created by Timothy Cheek on 2/25/14.
//
//

#ifndef __MyGame__PlayerObject__
#define __MyGame__PlayerObject__

#include "cocos2d.h"

class PlayerObject{
private:
    
    int nID;
    cocos2d::Point vPos;
    cocos2d::Rect bounds;
    cocos2d::Sprite* PlayerSprite;
    
public:
    
    PlayerObject();
    //destructor
    ~PlayerObject();
    
    //Getters
    cocos2d::Point GetPos();
    cocos2d::Rect GetBounds();
    int GetID();
    cocos2d::Sprite* GetSprite();
    
    //Setters
    void SetPos(cocos2d::Point pos);
    
    void Update();
};

#endif /* defined(__MyGame__PlayerObject__) */
