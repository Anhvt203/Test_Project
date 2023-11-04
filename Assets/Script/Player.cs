using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class Player : MonoBehaviour
{
    private int speed = 1;
    public GameObject start;
    public GameObject end;
    public GameObject[] path;
    private int step = 0;
    private bool isRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(stopPerSecond());
    }

    IEnumerator stopPerSecond()
    {
        yield return new WaitForSeconds(Random.Range(1f,2f));
        speed = 1 - speed;
        isRunning = true;
        //StartCoroutine(stopPerSecond());
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, path[step].transform.position, 0.01f * speed);
        if(transform.position == path[step].transform.position && isRunning)
        {
            isRunning = false;
            step = Random.Range(0, 5);
            
            StartCoroutine(stopPerSecond());
        }
        //chay tự động điểm 1 đến 5
        // if (transform.position == path[step].transform.position)
        // {
        //         // step++;
        // if (step == 5)
        // {
        //     gameObject.transform.position = start.transform.position;
        //     step = 0;
        // } 
        //}

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


