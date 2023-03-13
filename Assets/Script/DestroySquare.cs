using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySquare : MonoBehaviour
{
    public  int score=0;
    private int numberOfSquareDestroyed;
    public UpdateScore updateScore;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroySquareObject(collision);
        numberOfSquareDestroyed++;
        if(numberOfSquareDestroyed==2)
        {
            if(CircleCollision.alive)
            {
                score++;
                updateScore.SetScoreValue(score);
            }
            ResetNumberOfSquareDestroyed();
        }
    }
    int GetNumberOfSquareDestroy()
    {
        return numberOfSquareDestroyed;
    }
    void ResetNumberOfSquareDestroyed()
    {
        numberOfSquareDestroyed = 0;
    }
    public void setNumberOfSquareDestroyed(int value)
    {
        numberOfSquareDestroyed = value;
    }
    void DestroySquareObject(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
    public void DestroySquareObject(Collision2D collision,int value)
    {
        Destroy(collision.gameObject);
        setNumberOfSquareDestroyed(value);
    }
    public void ResetScore()
    {
        score = 0;
        updateScore.SetScoreValue(score);
    }
    
}
