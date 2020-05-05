using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zyouki : MonoBehaviour
{
    Rigidbody2D rigid;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 1) 
        {
            time += Time.deltaTime;
        }
        else
        {
            rigid.gravityScale = 0;
        }
    }
}
