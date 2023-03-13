using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private float leftBoundary = -10.3f;
    private float rightBoundary = 10.5f;
    public Vector3 movement;
    public int speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(CircleCollision.alive)
        {
            if(Input.GetKey(KeyCode.LeftArrow)&& gameObject.transform.position.x >= leftBoundary)
            {
                transform.position -= movement * speed * Time.deltaTime; 
            }
            else if (Input.GetKey(KeyCode.RightArrow)&& gameObject.transform.position.x <= rightBoundary)
            {
                transform.position += movement * speed * Time.deltaTime;
            }
        }
    }
}
