using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choilai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void resetman()
    {
        SceneManager.LoadScene("MAN1");
        Time.timeScale = 1;
    }
    public void chuyenman()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
}
