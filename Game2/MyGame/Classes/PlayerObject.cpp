//
//  PlayerObject.cpp
//  MyGame
//
//  Created by Timothy Cheek on 2/25/14.
//
//

#include "PlayerObject.h"

PlayerObject::PlayerObject()
{
    vPos = cocos2d::Point(600, 500);
    
    PlayerSprite = cocos2d::Sprite::create("Player.png");
    PlayerSprite->setPosition(vPos);
    
    
    bounds.setRect(0.0f, 0.0f, 10.0f, 10.0f);
    
    nID = 0;
}

PlayerObject::~PlayerObject()
{
    //PlayerSprite->release();
    
    //PlayerSprite = NULL;
}

//Getters
cocos2d::Point PlayerObject::GetPos()
{
    return vPos;
}

cocos2d::Rect PlayerObject::GetBounds()
{
    return bounds;
}

int PlayerObject::GetID()
{
    return nID;
}

cocos2d::Sprite* PlayerObject::GetSprite()
{
    return PlayerSprite;
}

//Setters
void PlayerObject::SetPos(cocos2d::Point pos)
{
    vPos = pos;
}

void PlayerObject::Update()
{
    
}