using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learning.Aditya
{
    public class PlayerController : MonoBehaviour
    {
        public int life;

        public float speed;
        private float moveDirection;


        // Update is called once per frame
        void Update()
        {
            Movement();
        }

        private void Movement()
        {
            moveDirection = Input.GetAxis("Horizontal");

            transform.position += moveDirection * speed * Time.deltaTime * Vector3.right;
        }
    }
}
