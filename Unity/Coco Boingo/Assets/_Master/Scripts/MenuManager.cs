using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
   public void Retry()
   {
        SceneManager.LoadScene(1);
   }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
