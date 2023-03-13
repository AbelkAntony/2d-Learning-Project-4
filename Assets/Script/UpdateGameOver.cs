using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateGameOver : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void SetGameOver()
    {
        if (CircleCollision.alive)
        {
            gameOver.SetActive(false);
        }
        else
        {
            gameOver.SetActive(true);
        }
    }
}
