using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bibord : MonoBehaviour
{
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(cam.position +cam.forward);
        
    }
}
