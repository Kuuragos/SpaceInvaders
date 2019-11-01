using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamikaze : MonoBehaviour
{
    public Transform followTo = null;
    public float followSpeed = 5f;

    void Awake()
    {
        followTo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (followTo == null)
            return;

        transform.position = Vector2.MoveTowards(transform.position, followTo.transform.position, followSpeed * Time.deltaTime);
        transform.forward = followTo.position - transform.position;
        Destroy(this.gameObject, 5f);
    }
}
