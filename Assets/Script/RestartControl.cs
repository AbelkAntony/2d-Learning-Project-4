using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RestartButton;
    public DestroySquare plane;
    public CircleCollision circle;
    public UpdateGameOver gameOver;
    public void SetRestart()
    {
        if (CircleCollision.alive)
        {
            RestartButton.SetActive(false);
        }
        else
        {
            RestartButton.SetActive(true);

        }
    }
    public void RestartNewGame()
    {
        CircleCollision.alive = true;
        Time.timeScale = 1;
        plane.ResetScore();
        circle.ResetLife();
        RestartButton.SetActive(false);
        gameOver.SetGameOver();
    }
       
 }


