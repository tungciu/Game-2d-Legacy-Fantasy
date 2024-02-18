using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosbo : MonoBehaviour
{
    public float start, end;
    private Animator Ani;
    private bool isRight;
    public GameObject player;
    public AudioSource no;
    private  Text Killedw;
    kilControler kiler;
    
    // Start is called before the first frame update
    void Start()
    {
 Ani = GetComponent<Animator>();
 kiler = GameObject.FindWithTag("kill").GetComponent<kilControler>();
 Killedw = GameObject.FindWithTag("kill").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        var positionEnemy = transform.position.x;
        
        // ruot nguoi choi
        var postionPlayer = player.transform.position.x;
        if (postionPlayer>start&&postionPlayer<end)
        {
            if (postionPlayer < positionEnemy) isRight = false;
            if (postionPlayer > positionEnemy) isRight = true;
            
            
        }
        
        
        if (positionEnemy<start)
        {
            isRight = true;

        }

        if (positionEnemy >end)
        {
            isRight = false;

        }
        

      //  Vector2 scale = transform.localScale;
        if (isRight)
        {
            // scale.x = -1.7378;
            transform.localScale=(new Vector3(-1.7378F, 1.7378F, 1.7378F));
            transform.Translate(Vector3.right*0.5f*Time.deltaTime);
            
        }
        else
        {
            transform.Translate(Vector3.left*0.5f*Time.deltaTime);
            transform.localScale=(new Vector3(1.7378F, 1.7378F, 1.7378F));
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.name);
        if (col.name=="Bullet(Clone)")
        {
            audiomanger.instance.PlaySoud(audiomanger.instance.qvdie,2f);
            kiler.Killed++;
            Killedw.text = "kill:" + kiler.Killed;
             Ani.Play("diebo");
            
            Destroy(gameObject,0.8f);
            Destroy(col.gameObject);
            
           
        }
    }
  
}

