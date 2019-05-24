using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMaker : MonoBehaviour
{
    public GameObject foodPrefab;
    public Sprite[] foodSprites;
    //private float time;
    private Transform foodHolder;
    private int xMax=15;
    private int yMax=12;
    private int xMin=-15;
    private int yMin=-11;
    // Start is called before the first frame update
    void Start()
    {
        foodHolder = GameObject.Find("FoodHolder").transform;
        //InvokeRepeating("MakeFood",0, time);
        Resources.Load
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MakeFood()
    {
        int index = Random.Range(0,foodSprites.Length);
        GameObject food = Instantiate(foodPrefab);
        food.transform.SetParent(foodHolder, false);
        int x = Random.Range(xMin,xMax);
        int y = Random.Range(yMin, yMax);
        food.transform.localPosition = new Vector3(x*30,y*30,0);
       
    }
}
