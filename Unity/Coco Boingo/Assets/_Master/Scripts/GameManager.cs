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
    private int score;
    public void AddScore(int scoreToAdd)
    {
        score+= scoreToAdd;
        StartCoroutine(ShowScore());
    }
    public void TakeLife()
    {
        lives--;
        Destroy(lifeSprites[lives].gameObject);
    }
    IEnumerator ShowScore()
    {
        yield return null;
        scoreTxt.text = score.ToString();
    }
}
