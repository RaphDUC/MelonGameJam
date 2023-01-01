using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

using UnityEngine.InputSystem;

public class PickUpObjects : MonoBehaviour
{

    [SerializeField]
    private Transform grabPoint;

    private RaycastHit2D hitInfo;

    private GameObject grabbedObject;
    private int layerIndex;
    private int layerMask;
    
    void Awake() {
        
       
    }
    // Start is called before the first frame update
    void Start()
    {
         layerMask = LayerMask.GetMask("Objects");
         hitInfo = Physics2D.Raycast(transform.position, transform.right, 2f, layerMask);
    }

    // Update is called once per frame
    void Update()
    {     
    

     if (hitInfo.collider)
         {
            Debug.DrawRay(transform.position, transform.right * 2f, Color.green);
            Debug.Log(hitInfo.collider.name);
            // //Prendre l'item
            // if (Keyboard.current.spaceKey.wasPressedThisFrame && grabbedObject == null)
            // {
            //     grabbedObject = hitInfoFridge.collider.gameObject;
            //     grabbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
            //     grabbedObject.transform.position = grabPoint.position;
            //     grabbedObject.transform.SetParent(transform);
            // }

            // //Rel�cher l'objet
            // else if (Keyboard.current.spaceKey.wasPressedThisFrame)
            // {
            //     grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
            //     grabbedObject.transform.SetParent(null);
    //         //     grabbedObject = null;
    //         // }
            
         } else {
            Debug.DrawRay(transform.position, transform.right * 2f, Color.red);
         }
     }
}
