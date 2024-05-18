using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public List<Transform> wayPoints;
    private int wayPointIndex;
    private float range;
    // Start is called before the first frame update
    void Start()
    {
        wayPointIndex = 0;
        range = 1.0f;
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        
    }

    void move()
    {
        transform.LookAt(wayPoints[wayPointIndex]);
        transform.Translate(Vector3.forward * speed  * Time.deltaTime);
        if(Vector3.Distance (transform.position, wayPoints[wayPointIndex].position)
            < range)
        {
            wayPointIndex++;
            if(wayPointIndex >= wayPoints.Count)
            {
                wayPointIndex = 0;
            }
        }
    }
}
