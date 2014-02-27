//
//  EnemyObject.h
//  MyGame
//
//  Created by Timothy Cheek on 2/26/14.
//
//

#ifndef __MyGame__EnemyObject__
#define __MyGame__EnemyObject__

#include "cocos2d.h"

class EnemyObject{
private:
    
    int nID;
    cocos2d::Point vPos;
    cocos2d::Rect bounds;
    cocos2d::Sprite* EnemySprite;
    
public:
    
    EnemyObject();
    //destructor
    ~EnemyObject();
    
    //Getters
    cocos2d::Point GetPos();
    cocos2d::Rect GetBounds();
    int GetID();
    cocos2d::Sprite* GetSprite();
    
    //Setters
    void SetPos(cocos2d::Point pos);
    
    //Enemy Update
    void Update();
    
};

#endif /* defined(__MyGame__EnemyObject__) */
