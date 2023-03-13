using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleCollision : MonoBehaviour
{
    public static bool alive = true;
    public DestroySquare square;
    public int numberOfLife=5;
    public UpdateLife updateLife;
    public UpdateGameOver gameOver;
    public RestartControl restart;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {

        numberOfLife--;
        if (numberOfLife < 1)
        {
            numberOfLife = 0;
            alive = false;
            restart.SetRestart();
            gameOver.SetGameOver();
            updateLife.SetLifeValue(numberOfLife);
            Time.timeScale = 0;
        }
        else
        {
            gameOver.SetGameOver();
            square.setNumberOfSquareDestroyed(-1);
            updateLife.SetLifeValue(numberOfLife);
        }

    }
    public void ResetLife()
    {
        numberOfLife = 5;
        updateLife.SetLifeValue(numberOfLife);
    }
   
}
