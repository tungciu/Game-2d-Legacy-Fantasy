using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlmapControler : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator amint;
    void Start()
    {
        amint = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        if (col.name=="Bullet(Clone)")
        {
            Destroy(col.gameObject);
              
              
        }
        // if (col.gameObject.tag=="danqv")
        // {
        //     Destroy(col.gameObject);
        //     
        // }
       
    }
}
