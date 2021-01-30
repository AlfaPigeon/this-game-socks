using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class Path : MonoBehaviour
{
    private AIDestinationSetter destination;
    public GameObject[] targets;
    public int index = 0;
    void Start()
    {
        destination = GetComponent<AIDestinationSetter>();
        destination.target = targets[index].transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nextTarget(){
        Debug.Log("next");
        if(targets.Length == 0)return;

        if(index == targets.Length - 1)
            index = 0;
        else
            index++;

        destination.target = targets[index].transform;
    }

     void OnTriggerEnter2D(Collider2D col)
    {

        if(col.gameObject.Equals(targets[index])){
            Debug.Log("Trigger");
            nextTarget();
        }
    }
    
}
