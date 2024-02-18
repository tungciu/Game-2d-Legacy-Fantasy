using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boscontroler : MonoBehaviour
{
    private Animator Ani;
    private  Text Killedw;
    kilControler kiler;
    public GameObject bullet;
    private buletControler b;
    private float fireRate = 1f; // số giây giữa mỗi lần bắn viên đạn
    private float nextFireTime = 0f; // thời gian bắn viên đạn tiếp theo

   
    void Start()
    {
        b = bullet.GetComponent<buletControler>();
        Ani = GetComponent<Animator>();
        kiler = GameObject.FindWithTag("kill").GetComponent<kilControler>();
        Killedw = GameObject.FindWithTag("kill").GetComponent<Text>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFireTime) // nếu đã đến thời điểm bắn viên đạn tiếp theo
        {
            nextFireTime = Time.time + fireRate; // cập nhật lại thời gian bắn viên đạn tiếp theo
            Instantiate(bullet, transform.position, Quaternion.identity);
            b.direction = Vector3.left;
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
            Ani.Play("dieqvxanh");
            
            Destroy(gameObject,0.8f);
            Destroy(col.gameObject);
        }

       
       
    }
    

    
    
}
