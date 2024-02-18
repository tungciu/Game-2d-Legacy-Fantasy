using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xucontroler : MonoBehaviour
{
    // private  Text Killedw;
    // xucounts kiler;
    
    // Start is called before the first frame update
    void Start()
    {   
        // kiler = GameObject.FindWithTag("xu").GetComponent<xucounts>();
        // Killedw = GameObject.FindWithTag("xu").GetComponent<Text>();
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
    //      kiler.Killed++;
    //    Killedw.text = "xu:" + kiler.Killed;
    }
}
