using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        obj = this;
    }
    public static GameManager obj;
    public TextMeshProUGUI scoreTxt;
    public List<Image> lifeSprites;
    public int lives = 3;
    private int score = 0;
    public GameObject panel;
    public UnityEvent defeat;
    private void Start()
    {
        StartCoroutine(ShowScore());
        Time.timeScale = 1;

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
        if(lives <= 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            defeat.Invoke();
        }
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
    private void OnDestroy()
    {
        obj = null;
    }
}
