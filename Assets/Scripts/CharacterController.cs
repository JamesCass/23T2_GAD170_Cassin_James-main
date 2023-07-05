using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    //move object based on imputs from the player W,A,S,D
    private void Update()
    {
      
        //if(Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right;
        //}
        //if(Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left;
        //}
        //if(Input.GetKey(KeyCode.W))
        //{
        //  transform.position += Vector3.forward;
        //}
        //if(Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back;
        //}
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0, Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
