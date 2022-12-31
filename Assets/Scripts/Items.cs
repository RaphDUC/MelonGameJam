using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public Transform fridge;
    public Transform tv;
    public Transform closet;

    public GameObject[] typeItems;
    // Start is called before the first frame update
    void Awake(){
        fridge = typeItems[0].transform;
        tv = typeItems[1].transform;
        closet = typeItems[2].transform;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
