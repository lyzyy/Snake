using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    public float velocity;//速度
    public int step;//每次前进几步
    private int x;
    private int y;
    private Vector3 headPos;
    // Start is called before the first frame update

    void Start()
    {
        InvokeRepeating("Move", 0, velocity);
        x = 0;
        y = step;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            x = 0;y = step;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            x = 0;y = -step;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            x = -step;y = 0;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = step;y = 0;
        }
    }
    void Move()
    {
        headPos = gameObject.transform.localPosition;
        gameObject.transform.localPosition = new Vector3(headPos.x + x,headPos.y + y,headPos.z);
        
    }
}
