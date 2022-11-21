using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public GameObject goal;
    public float speed;

    private Transform tGoal;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        tGoal = goal.transform;
        this.transform.LookAt(tGoal.position);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = tGoal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }
}
