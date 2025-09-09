using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Item potion;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        potion = new Item("Heal Potion", 10);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            potion.Use(5);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            // itemManager.poison.Use();
        }
    }
}
