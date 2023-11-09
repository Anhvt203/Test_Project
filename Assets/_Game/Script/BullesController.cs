using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesController : MonoBehaviour
{
    public Transform start;
    public Transform end;
    private GameObject gameController;
    private bool road = true;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        start = gameController.GetComponent<GameController>().getStartTransform();
        end = gameController.GetComponent<GameController>().getEndTransform();
        target = end;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.005f);
        if(transform.position == target.transform.position)
        {
            if (road)
            {
                target = start;
                road = !road;
            }else
            {
                target = end;
                road = !road;
            }
        }
    }
}
