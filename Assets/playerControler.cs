using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerControler : MonoBehaviour
{
    // Start is called before the first frame update
   // private string Playe = "playe";
    private Rigidbody2D myBody;
    private Animator amin;
//hp
    public int maxhelthy = 100;
    public int curenrhelthy;
    private int dungim = 0;
    public HelthyBar helthyBar;
    //het hp
    public GameObject bullet,menu,menu2,menu3;
    private buletControler b;
    private bool isNen;
    private bool isPlayIng=true;
    
    private  Text Killedw;
    xucounts kiler;
    
    void Start()
    {
        helthyBar.SetMaxhelthy(maxhelthy);
        curenrhelthy = maxhelthy;
        myBody = GetComponent<Rigidbody2D>();
        amin = GetComponent<Animator>();
        b = bullet.GetComponent<buletControler>();
        audiomanger.instance.PlaySoud(audiomanger.instance.nen,0.4f,true);
        kiler = GameObject.FindWithTag("soxu").GetComponent<xucounts>();
        Killedw = GameObject.FindWithTag("soxu").GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audiomanger.instance.PlaySoud(audiomanger.instance.chem,2f);
            // amin.SetInteger("playe",skil);
            amin.Play("skil");
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
        else
       
        if (Input.GetKey(KeyCode.A))
        {
            // amin.SetInteger("playe", run);
            audiomanger.instance.PlaySoud(audiomanger.instance.dibo,2f);
            amin.Play("run");
            transform.Translate(Vector3.left * 1f * Time.deltaTime);
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? -1 : 1;
            transform.localScale = scale;
            b.direction=Vector3.left;
            b.transform.localScale=(new Vector3(-0.1000996F, 0.1091944F, 0.1937099F));
        }
       
        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (isNen)
            {
                // amin.SetInteger("playe",nhay);
                audiomanger.instance.PlaySoud(audiomanger.instance.nhay,1f);
                amin.Play("jume");
              
                myBody.AddForce(Vector2.up*4.7f,ForceMode2D.Impulse);
                isNen = false;
            }
           
        } 
        else if (Input.GetKey(KeyCode.D))
        {
           
            audiomanger.instance.PlaySoud(audiomanger.instance.dibo,2f);
            
            amin.Play("run");
            transform.Translate(Vector3.right * 1f * Time.deltaTime);
            
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? 1 : -1;
            transform.localScale = scale;
            b.direction = Vector3.right;
            b.transform.localScale=(new Vector3(0.1000996F, 0.1091944F, 0.1937099F));
        }
        else
          
        {
          amin.SetInteger("playe",dungim);
        }
        // showmenu
        if (Input.GetKeyDown(KeyCode.B))
        {
          showmenu();

        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag=="nen")
        {
            isNen = true;

        }

        if (col.gameObject.tag=="xu")
        {  
            kiler.Killed++;
            Killedw.text = "xu:" + kiler.Killed;
            Destroy(col.gameObject);
            audiomanger.instance.PlaySoud(audiomanger.instance.xu,1f);
            
            
        }

        if (col.gameObject.tag=="bos1")
        {
            transform.Translate(Time.deltaTime *25,0,0);
            TakeDamge(10);
            
        }
        if (col.gameObject.tag=="back")
        {
            Time.timeScale = 0;
            
        }
        if (col.gameObject.tag=="man2")
        {
            SceneManager.LoadScene(2);
        }
        if (col.gameObject.tag=="win")
        {
            menu3.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.tag=="danqv")
        {
            TakeDamge(20);
            amin.Play("die");
        }
        if (col.gameObject.tag=="hp")
        {
            hp(10);
            amin.Play("hpdie");
        }
        
    }
    

    public void showmenu()
    {
        if (isPlayIng)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            isPlayIng = false;
        }
        else
        {
            menu.SetActive(false);
            Time.timeScale = 1;
            isPlayIng = true;
        }
    }

    void TakeDamge(int damge)
    {
        curenrhelthy -= damge;
        if (curenrhelthy==0)
        {
            Time.timeScale = 0;
            menu2.SetActive(true);
            Destroy(gameObject);
        }
        else
        {
            Time.timeScale = 1;
            
        }
    
      
        helthyBar.setHelthybar(curenrhelthy);
    }
    //
    void hp(int damge)
    {
        curenrhelthy += damge;
        
        helthyBar.setHelthybar(curenrhelthy);
    }
}
