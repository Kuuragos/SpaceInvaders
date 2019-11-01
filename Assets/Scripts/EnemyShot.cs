using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject misil;
    float ratioDisparo = 2f;
    float siguienteDis;
    float velocidadMisil = 750;


    void Update()
    {
        if (Time.time > siguienteDis)
        {
            siguienteDis = Time.time + ratioDisparo;
            GameObject misilInstantiate = Instantiate(misil, transform.position, Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
            Rigidbody rigidbody = misilInstantiate.GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.down * velocidadMisil);
            Destroy(misilInstantiate, 2f);
        }
    }
}
