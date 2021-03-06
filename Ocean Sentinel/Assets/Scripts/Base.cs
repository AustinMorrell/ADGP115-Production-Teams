﻿////////////////////////////////////////////////////////////////
//Austin Morrell//
//May 31 2016//
//ADGP-115 Production Teams//
///////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour
{

    // The max amount of HP the base can have.
    public float max_HP;
    // The amount of HP the base has.
    public float HP;
    // The max amount of Armor the base can have.
    public float max_Armor;
    // The amount of armor the base has.
    public float Armor;
    // The GameController.
    public GameController GC;
    // Stops the check for losing
    private bool Stop;


    // This is used for initialization.

    void Start()
    {

        GC = FindObjectOfType<GameController>();
        max_HP = 300;
        max_Armor = 200;
        HP = max_HP;
        Armor = max_Armor;
        Stop = false;
    }

    // Is called every frame.
    void Update()
    {
        // Makes sure armor can never be negative.
        if (Armor <= 0)
        {
            Armor = 0;
        }

        // If the base has no HP left you lose.
        if (HP <= 0 && Stop == false)
        {
            HP = 0;
            GameObject explosion = (GameObject)Instantiate(Resources.Load("Explosion", typeof(GameObject)));
            explosion.transform.position = transform.position;
            Destroy(gameObject.GetComponent<MeshRenderer>());
            StartCoroutine(Wait(2));
            Stop = true;
        }
    }

    private IEnumerator Wait(float a)
    {
        yield return new WaitForSeconds(a);
        GC.GameOver();
    }
}