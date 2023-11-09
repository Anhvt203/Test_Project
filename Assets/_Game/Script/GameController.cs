using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject characterPerfabs;
    public Transform start;
    public Transform end;
    public GameObject[] path_right;
    public GameObject[] path_left;

    void Start()
    {
        InvokeRepeating(nameof(spawnCharacter), 1f,1f);
    }
    public GameObject[] returnPath()
    {
        if (Random.Range(0, 2)== 1)
        {
            return path_left;
        }
        return path_right;
    }

    public Transform getStartTransform() {
        return start;
    }
    public Transform getEndTransform() {
        return start;
    }
    void spawnCharacter(){
        GameObject Character = Instantiate(characterPerfabs, start.transform.position, start.transform.rotation); 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
