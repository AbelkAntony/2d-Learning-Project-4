using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learning.Aditya
{
    public class ObstacleDestroyScript : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(collision.gameObject);
        }
    }
}
