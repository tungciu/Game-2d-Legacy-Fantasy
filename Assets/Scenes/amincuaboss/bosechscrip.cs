using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosechscrip : MonoBehaviour
{
    private Animator Ani;
    private  Text Killedw;
    kilControler kiler;
    
    public GameObject player;
    public float start;
    public float end;
    public float speed = 0.5f; // tốc độ ban đầu của quái vật
    private bool isRight = false;
    
    public GameObject bullet;
    private buletControler b;
    private float fireRate = 0.3f; // số giây giữa mỗi lần bắn viên đạn
    private float nextFireTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        kiler = GameObject.FindWithTag("kill").GetComponent<kilControler>();
        Killedw = GameObject.FindWithTag("kill").GetComponent<Text>();
 Ani = GetComponent<Animator>();
    }
   // private void Update()
   // {
   //     var positionEnemy = transform.position.x;
   //
   //     // Vị trí của nhân vật
   //     var postionPlayer = player.transform.position.x;
   //
   //     if (postionPlayer > start && postionPlayer < end)
   //     {
   //         // Nếu nhân vật đang ở bên trái quái
   //         if (postionPlayer < positionEnemy)
   //         {
   //             isRight = false;
   //
   //             // Bắn đạn sang phải
   //             if (Time.time > nextFireTime)
   //             {
   //                 nextFireTime = Time.time + fireRate;
   //                 var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
   //                 bulletInstance.direction = Vector3.right;
   //                 bulletInstance.transform.localScale = new Vector3(-1F, 1F, 1F);
   //             }
   //         }
   //
   //         // Nếu nhân vật đang ở bên phải quái
   //         if (postionPlayer > positionEnemy)
   //         {
   //             isRight = true;
   //
   //             // Bắn đạn sang trái
   //             if (Time.time > nextFireTime)
   //             {
   //                 nextFireTime = Time.time + fireRate;
   //                 var bulletInstance = Instantiate(bullet, transform.position, Quaternion.identity);
   //                 bulletInstance.direction = Vector3.left;
   //                 bulletInstance.transform.localScale = new Vector3(1F, 1F, 1F);
   //             }
   //         }
   //
   //         // Khi nhân vật vào vùng di chuyển, tăng tốc độ quái vật lên gấp đôi
   //         speed *= 2f;
   //     }
   //
   //     if (positionEnemy < start)
   //     {
   //         isRight = true;
   //     }
   //
   //     if (positionEnemy > end)
   //     {
   //         isRight = false;
   //     }
   //
   //     if (isRight)
   //     {
   //         transform.localScale = new Vector3(-1.7378F, 1.7378F, 1.7378F);
   //         transform.Translate(Vector3.right * speed * Time.deltaTime);
   //     }
   //     else
   //     {
   //         transform.localScale = new Vector3(1.7378F, 1.7378F, 1.7378F);
   //         transform.Translate(Vector3.left * speed * Time.deltaTime);
   //     }
   // }


    // Update is called once per frame
    void Update()
    {
        var positionEnemy = transform.position.x;
        
        // ruot nguoi choi
        var postionPlayer = player.transform.position.x;
        if (postionPlayer>start&&postionPlayer<end)
        {
            if (postionPlayer < positionEnemy)
            {
                isRight = false;
                if (Time.time > nextFireTime)
                {
                    nextFireTime = Time.time + fireRate;
                 Instantiate(bullet, transform.position, Quaternion.identity);
                    b.direction = Vector3.right;
                    b.transform.localScale = new Vector3(-1F, 1F, 1F);
                }
            }
    
            if (postionPlayer > positionEnemy)
            {
                isRight = true;
            }
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
             Ani.Play("dieech");
            
            Destroy(gameObject,0.8f);
            Destroy(col.gameObject);
            
           
        }
    }
  
}

