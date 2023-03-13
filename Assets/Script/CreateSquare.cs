using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSquare : MonoBehaviour
{
    public float timeDuration;
    private float timer;
    private float resetTime;
    public GameObject square;
    public Vector3 squarePosition;
    private int tempNumber = 0;
    private int randomNumber ;

    // Start is called before the first frame update
    void Start()
    {
        resetTime = timeDuration;
        newSquare();
    }

    // Update is called once per frame
    void Update()
    {
        if (CircleCollision.alive)
        {
            timer += Time.deltaTime;
            if(resetTime < timer)
            {
                newSquare();
                resetTime = timer + timeDuration;
            }

        }
    }
    void newSquare()
    {
        for (int i=0; i<2; i++)
        {
            while(tempNumber == randomNumber)
            {
             randomNumber = Random.Range(-3,3);
            }
            tempNumber = randomNumber;
            Instantiate(square,new Vector3(randomNumber*3, 6, 0), Quaternion.identity );
        }
    }
}
