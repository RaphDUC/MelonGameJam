using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetItems : MonoBehaviour
{
    public GameObject items;

    [HideInInspector]
    public static ClosetItems instance;

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
