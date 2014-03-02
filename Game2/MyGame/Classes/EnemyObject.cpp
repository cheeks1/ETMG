//
//  EnemyObject.cpp
//  MyGame
//
//  Created by Timothy Cheek on 2/26/14.
//
//

#include "EnemyObject.h"

EnemyObject::EnemyObject()
{
    
    vPos = cocos2d::Point(200, 200);
    
    EnemySprite = cocos2d::Sprite::create("Enemy.png");
    EnemySprite->setPosition(vPos);
   
    bounds.setRect(0.0f, 0.0f, 10.0f, 10.0f);
    
    nID = 1;
}

EnemyObject::~EnemyObject()
{
    //EnemySprite->release();
    
    //EnemySprite = NULL;
}

//Getters
cocos2d::Point EnemyObject::GetPos()
{
    return vPos;
}

cocos2d::Rect EnemyObject::GetBounds()
{
    return bounds;
}

int EnemyObject::GetID()
{
    return nID;
}

cocos2d::Sprite* EnemyObject::GetSprite()
{
    return EnemySprite;
}

//Setters
void EnemyObject::SetPos(cocos2d::Point pos)
{
    vPos = pos;
    
    EnemySprite->setPosition(vPos);
    
    bounds.setRect(vPos.x - 32.0f, vPos.y - 32.0f, vPos.x + 32.0f, vPos.y + 32.0f);
}

void EnemyObject::Update()
{
    
}