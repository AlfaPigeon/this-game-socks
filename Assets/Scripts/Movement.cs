using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rg;
    CharacterController charCtrl;
    // Use this for initialization
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        charCtrl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        float z = transform.rotation.z;
        //Debug.Log("h: "+horizontalInput+" v: "+verticalInput);
        
        if( z < 0 && z > -0.70){

        }else if( z < -0.70 && z > -1){

        }else if( z < 1 && z > 0.70){

        }else if( z > 0 && z < 0.30){

        }
    }




}
