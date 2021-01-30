using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public Collider2D[] colliders;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            foreach (Collider2D collider in colliders)
            {
                collider.enabled = false;
            }
            RaycastHit2D raycast = Physics2D.Raycast(transform.position, other.transform.position -transform.position);
            Debug.DrawRay(transform.position, other.transform.position -transform.position, Color.green);
            
            if (raycast != null)
            {
                if (raycast.collider.gameObject.tag == "Player")
                {
                    //Do some killing stuff 
                }
            }
        }
        
        foreach (Collider2D collider in colliders)
        {
            collider.enabled = true;
        }
    }
}
