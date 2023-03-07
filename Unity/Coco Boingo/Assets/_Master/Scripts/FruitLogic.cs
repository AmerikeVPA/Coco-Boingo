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
    [SerializeField] private float limitY = -20f;
    private Rigidbody rb;

    private void Awake()
    {
        manager = FindObjectOfType<GameManager>();
        rb= GetComponent<Rigidbody>();
    }
    void FruitDeath()
    {
        gameObject.SetActive(false);
        bounces= 0;
        rb.velocity = Vector3.zero;
    }
    private void Update()
    {
        OutOfLimits();
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
    private void OutOfLimits()
    {
        if(transform.position.y <= limitY)
        {
            FruitDeath();
        }
    }
}
