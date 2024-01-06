using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{ 
    public float speed ;
    public Transform Target ;
    public Vector3 offset;



void LateUpdate()
{
    Movement();
}

    public void Movement(){
        Vector3 movement = Target.transform.position + offset;
        Vector3 smooth = Vector3.Lerp(this.transform.position , movement , speed  );
        this.gameObject.transform.position = smooth;
    }
    
}
