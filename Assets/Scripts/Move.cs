using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 0.1f;
    void Update()
    {
       if(Input.GetKey(KeyCode.W) && transform.position.y < 5.36)
        {
            transform.position += transform.forward * speed;
        }
       
       if (Input.GetKey(KeyCode.S) && transform.position.y > -5)
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -11.38)
        {
            transform.position -= Vector3.right * speed;
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < 11.38)
        {
            transform.position += Vector3.right * speed;
        }
        else
            transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));
    }
}
