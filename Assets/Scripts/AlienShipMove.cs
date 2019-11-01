using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShipMove : MonoBehaviour
{
    public float horDistance = 3.5f;
    public float verDistance = 2.5f;
    public float speed = 0.8f;
    private float startTime;
    private Vector3 startingPosition;
    private Vector3 target;

    void Start()
    {
        this.startTime = Time.time;
        this.startingPosition = this.transform.position;
        this.target = this.startingPosition + new Vector3(this.horDistance, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        Vector3 newPosition = Vector3.MoveTowards(currentPosition, this.target, speed * Time.deltaTime);
        this.transform.position = newPosition;

        
        if (newPosition == target)
        {
            if (newPosition.x == startingPosition.x)
            {
                if (((newPosition.y - startingPosition.y) / verDistance) % 2 == 0)
                    this.target = newPosition + new Vector3(this.horDistance, 0, 0);
                else
                    this.target = newPosition - new Vector3(0, this.verDistance, 0);
            }
            else
            {
                if (((newPosition.y - startingPosition.y) / verDistance) % 2 != 0)
                    this.target = newPosition - new Vector3(this.horDistance, 0, 0);
                else
                    this.target = newPosition - new Vector3(0, this.verDistance, 0);
            }
        }
    }
}
