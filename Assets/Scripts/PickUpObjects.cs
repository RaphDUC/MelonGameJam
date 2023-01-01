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

    private int layerMask;
    private SpriteRenderer sr;
    
    void Awake() {
        
       layerMask = LayerMask.GetMask("Objects");
       sr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
         
         
    }

    // Update is called once per frame
    void Update()
    {     
     if(sr.flipX == true){
          hitInfo = Physics2D.Raycast(transform.position, Vector2.left, 2f, layerMask);          
     } else {
          hitInfo = Physics2D.Raycast(transform.position, Vector2.right, 2f, layerMask);  
     }


     if (hitInfo.collider)
         {
               if(sr.flipX == true){
                    Debug.DrawRay(transform.position, Vector2.left * 2f, Color.green);        
               }

               else {
                    Debug.DrawRay(transform.position, Vector2.right * 2f, Color.green);
               }

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
            
         } 
         else {
               if(sr.flipX == true){
                    Debug.DrawRay(transform.position, Vector2.left * 2f, Color.red);        
               }

               else {
                    Debug.DrawRay(transform.position, Vector2.right * 2f, Color.red);
               }
         }
     }
}
