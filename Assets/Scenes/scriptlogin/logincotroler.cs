using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;


public class logincotroler : MonoBehaviour
{
    public TMP_InputField name, pasword;

    public TMP_Text txtThong;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checklogin()
    {
        var nameck = name.text;
        var pas = pasword.text;
        if (nameck.Equals("tung") && pas.Equals("2311"))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            txtThong.text = "sai mk hoac ten";
        }
    }
}
