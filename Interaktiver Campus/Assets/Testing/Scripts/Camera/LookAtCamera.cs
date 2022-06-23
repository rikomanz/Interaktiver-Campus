using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    //public Transform Target;

    void Start ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(2 * transform.position - Camera.allCameras[0].transform.position);
    }
}
