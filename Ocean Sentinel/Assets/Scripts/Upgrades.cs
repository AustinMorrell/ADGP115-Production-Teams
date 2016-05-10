﻿using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour {

    [SerializeField]
    private GameObject GC;
    [SerializeField]
    private GameObject TheBase;
    [SerializeField]
    private GameObject PM;
	
	public void Repair()
    {
        if (GC.GetComponent<GameController>().Gold >= 30)
        {
            TheBase.GetComponent<Base>().HP += 200;
            if (TheBase.GetComponent<Base>().HP > TheBase.GetComponent<Base>().max_HP)
            {
                TheBase.GetComponent<Base>().HP = TheBase.GetComponent<Base>().max_HP;
            }
            GC.GetComponent<GameController>().Gold -= 30;
            GC.GetComponent<GameController>().spawnWave = true;
            GC.GetComponent<GameController>().StartCoroutine(GC.GetComponent<GameController>().SpawnWaves());
        }
    }

    public void Armor()
    {

    }

    public void Speed()
    {
        if (GC.GetComponent<GameController>().Gold >= 15)
        {
            PM.GetComponent<PlayerMovement>().MoveVelocity += 5;
            GC.GetComponent<GameController>().Gold -= 15;
            GC.GetComponent<GameController>().spawnWave = true;
            GC.GetComponent<GameController>().StartCoroutine(GC.GetComponent<GameController>().SpawnWaves());
        }
    }

    public void Rate()
    {

    }

    public void None()
    {
        GC.GetComponent<GameController>().spawnWave = true;
        GC.GetComponent<GameController>().StartCoroutine(GC.GetComponent<GameController>().SpawnWaves());
    }
}
