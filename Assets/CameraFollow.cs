using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

public Transform target;
Vector3 offsetVector;
    // Start is called before the first frame update
    void Start()
    {
        offsetVector = this.transform.position - target.position;
    }


    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(target);
        Vector3 newpos = target.position + offsetVector;
        //newpos.y = this.transform.position.y;
        //newpos.z = this.transform.position.z;

        Vector3 moveVector = this.transform.position - newpos;
        moveVector *= 0.25f;
        newpos += moveVector;
        this.transform.position = newpos;

        //this.transform.position = Vector3.MoveTowards(this.transform.position, newpos, 0.01f);
    }
}
