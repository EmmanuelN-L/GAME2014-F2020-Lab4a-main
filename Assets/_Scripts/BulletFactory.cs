﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject regularBullet;
    public GameObject fatBullet;
    public GameObject pulsingBullet;


    public GameObject createBullet(BulletType type = BulletType.RANDOM)
    {
        if(type == BulletType.RANDOM)
        {
            var randomBullet = UnityEngine.Random.Range(0, 3);
            type = (BulletType)randomBullet;

        }

        GameObject tempBullet = null;
        switch (type)
        {
            case BulletType.REGULAR:
                tempBullet = Instantiate(regularBullet);
                break;
            case BulletType.FAT:
                tempBullet = Instantiate(fatBullet);
                break;
            case BulletType.PULSING:
                tempBullet = Instantiate(pulsingBullet);
                break;
        }
        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);
        return tempBullet;
    }
      
    
}
