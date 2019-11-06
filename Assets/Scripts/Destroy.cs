using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject explode;
    public GameObject playerExplode;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
            return;
        
        if (other.tag == "player")
            Instantiate(explode, other.transform.position, other.transform.rotation);

        Instantiate(playerExplode, transform.position, transform.rotation);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}