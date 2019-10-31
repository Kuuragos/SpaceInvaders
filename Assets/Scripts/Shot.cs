using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Rigidbody misil;
    public Transform misilPosition;
    float ratioDisparo = 0.25f;
    float siguienteDis;
    float velocidadMisil = 150f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > siguienteDis)
        {
            siguienteDis = Time.time + ratioDisparo;
            Rigidbody misilInstantiate = Instantiate(misil, misilPosition.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
            misilInstantiate.velocity = transform.TransformDirection(new Vector3(0, 0, Time.deltaTime * velocidadMisil));
        }
    }
}
