using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public List<Image> lifeSprites;
    public int lives = 3;
    private int score = 0;
    private void Start()
    {
        StartCoroutine(ShowScore());
    }
    public void AddScore(int scoreToAdd)
    {
        score+= scoreToAdd;
        StartCoroutine(ShowScore());
    }
    public void TakeLife()
    {
        lives--;
        lifeSprites[lives].gameObject.SetActive(false);
    }
    public void AddLife()
    {
        if (lives < 3)
        {
            lives++;
            lifeSprites[lives].gameObject.SetActive(true);
        }
    }
    IEnumerator ShowScore()
    {
        yield return null;
        scoreTxt.text = score.ToString();
    }
}
