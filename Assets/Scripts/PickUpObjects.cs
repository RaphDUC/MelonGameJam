using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpObjects : MonoBehaviour
{

    [SerializeField]

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

     }

     void OnPickup_Interact(InputValue value){
          if (hitInfo.collider)
         {
                       // //Prendre l'item
             if (value.isPressed && grabbedObject == null)
             {
               Debug.Log("action called !");

               grabbedObject = Instantiate(FridgeItems.instance.items);
               grabbedObject.transform.position = transform.position + new Vector3(1f, 0f, 0f);
               grabbedObject.transform.SetParent(transform);
             }

            // //Rel�cher l'objet         
         } 

           if (!value.isPressed && grabbedObject != null)
             {
               Debug.Log("objet relaché");
                 grabbedObject.transform.SetParent(null);
                 Destroy(grabbedObject);
             }  

     }
}
