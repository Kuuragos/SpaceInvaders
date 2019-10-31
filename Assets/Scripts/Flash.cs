using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public GameObject flash1;
    public GameObject flash2;

    void Start()
    {
        flash1.SetActive(false);
        flash2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey (KeyCode.Space))
        {
            flash1.SetActive(true);
            flash2.SetActive(true);
        }
        else
        {
            flash1.SetActive(false);
            flash2.SetActive(false);
        }
    }
}
