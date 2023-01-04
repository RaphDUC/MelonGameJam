using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeItems : MonoBehaviour
{

    public GameObject items;

    [HideInInspector]
    public static FridgeItems instance;

    void Awake(){
        if(!instance){
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
