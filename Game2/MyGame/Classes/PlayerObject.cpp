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
    vPos = cocos2d::Point(50, 500);
    
    PlayerSprite = cocos2d::Sprite::create("Player.png");
    PlayerSprite->setPosition(vPos);
    
    bounds.setRect(vPos.x - 32.0f, vPos.y - 32.0f, vPos.x + 32.0f, vPos.y + 32.0f);
    
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
    PlayerSprite->setPosition(vPos);
    
    bounds.setRect(vPos.x - 16.0f, vPos.y - 16.0f, vPos.x + 16.0f, vPos.y + 16.0f);
}

void PlayerObject::Update()
{
    
}