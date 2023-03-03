using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FruitLogic : MonoBehaviour
{
    public int fruitScore = 0;
    public bool vegetable, avocado;
    private GameManager manager;
    private int bounces = 0;

    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
    }
    void FruitDeath()
    {
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basket")
        {
            manager.AddScore(fruitScore);
            if (vegetable) manager.TakeLife();
            if (avocado) manager.AddLife();
            FruitDeath();
            return;
        }
        bounces++;
        if(bounces > 2) FruitDeath();
    }
}
