using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosoc : MonoBehaviour
{
    public float start, end;
    private Animator Ani;
    private bool isRight;
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
            transform.localScale=(new Vector3(-1.3743F, 1.3743F, 1.3743F));
            transform.Translate(Vector3.right*0.2f*Time.deltaTime);
            
        }
        else
        {
            transform.Translate(Vector3.left*0.2f*Time.deltaTime);
            transform.localScale=(new Vector3(1.3743F, 1.3743F, 1.3743F));
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
            Ani.Play("ocsendie");
            
            Destroy(gameObject,0.8f);
            Destroy(col.gameObject);
            
           
        }
    }

}

