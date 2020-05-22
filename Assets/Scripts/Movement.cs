using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{

    Rigidbody rb;
    public Camera c;
    GameObject player;
    public float speed = 15;
    public float speedside = 15;
    public bool dead = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    { 
       c.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z + -4);
        Move();
    }


    void Move()
    {
        if (dead == false)
        {
            rb.AddForce(0, 0, speed * Time.deltaTime, ForceMode.Force);

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(speedside * Time.deltaTime, 0, 0, ForceMode.Force);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-speedside * Time.deltaTime, 0, 0, ForceMode.Force);
            }

        }
        else
        {
            Debug.Log("Dead!");
        }
    }
    public void Death()
    {
        dead = true;
    }
}
