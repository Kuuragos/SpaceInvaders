using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject misil;
    float ratioDisparo = 0.25f;
    float siguienteDis;
    float velocidadMisil = 750;

    void Awake()
    {
        transform.tag = "Misil";
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > siguienteDis)
        {
            siguienteDis = Time.time + ratioDisparo;
            GameObject misilInstantiate = Instantiate(misil, transform.position, Quaternion.Euler(new Vector3 (-90,0,0))) as GameObject;
            Rigidbody rigidbody = misilInstantiate.GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * velocidadMisil);
            Destroy(misilInstantiate, 2f);
        }
    }
}
