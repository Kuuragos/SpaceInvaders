using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 0.1f;
    void Update()
    {
       if(Input.GetKey(KeyCode.W) && transform.position.y < 0)
        {
            transform.position += transform.forward * speed;
        }
       
       if (Input.GetKey(KeyCode.S) && transform.position.y > -5)
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -7.07)
        {
            transform.position -= Vector3.right * speed;
            transform.rotation = Quaternion.Euler(new Vector3(-90, 35, 5));
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < 7.07)
        {
            transform.position += Vector3.right * speed;
            transform.rotation = Quaternion.Euler(new Vector3(-90, -35, -5));
        }
        else
            transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 0));
    }
}
