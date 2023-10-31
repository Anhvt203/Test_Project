using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 1;
    public GameObject start;
    public GameObject end;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, end.transform.position, 0.01f);
        //di chuyen
        // if (Input.GetKey("w"))
        // {
        //     transform.Translate(Vector3.up * Time.deltaTime * speed);//de nhan vat di chuyen time.deltatime chinh
        // }
        // if (Input.GetKey("s"))
        // {
        //     transform.Translate(Vector3.down * Time.deltaTime * speed);
        // }
        // if (Input.GetKey("a"))
        // {
        //     transform.Translate(Vector3.left * Time.deltaTime * speed);
        // }
        // if (Input.GetKey("d"))
        // {
        //     transform.Translate(Vector3.right * Time.deltaTime * speed);
        // }
        // if(absNumber(gameObject.transform.position.x,end.transform.position.x) < 0.1f && absNumber(gameObject.transform.position.y,end.transform.position.y) < 0.1f)
        // {
        //     //gan vi tri
        //     gameObject.transform.position = start.transform.position;
        // }
    }
    // private float absNumber(float x, float y)
    // {
    //     if (x - y > 0)
    //     {
    //         return x - y;
    //     }
    //     return y - x;
    // }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "End")
        {
            gameObject.transform.position = start.transform.position;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {

    }
    void OnTriggerExit2D(Collider2D col) 
    {

    }
}


