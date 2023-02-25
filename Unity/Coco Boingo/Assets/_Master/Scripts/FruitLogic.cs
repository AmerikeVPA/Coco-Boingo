using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitLogic : MonoBehaviour
{
    int bounceCount = 0;
    public int countScore = 0;
    private void Update()
    {
        FruitDeath();
    }
    void FruitDeath()
    {
        if(bounceCount == 2)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basket")
        {
            countScore++;
            Debug.Log(countScore);
        }
        bounceCount++;
    }
}
