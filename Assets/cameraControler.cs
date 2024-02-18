using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public GameObject Player;

    // lưu ý ánh xạ gamneojbect  player trên secen vô biến này
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Player.transform.position.x;
        float y = Player.transform.position.y;
        float z = Player.transform.position.z;
        transform.position = new Vector3(x, y, z - 10f);
        // z- đi 1 khoản > thuộc tính nera của camer
    }
}
