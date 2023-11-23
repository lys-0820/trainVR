using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = new Vector3(transform.position.x, 0, transform.position.z) - new Vector3(cam.transform.position.x, 0, cam.transform.position.z)-new Vector3(0,0,270);   

    }

}
