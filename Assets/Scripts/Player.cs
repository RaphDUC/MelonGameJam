using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D myBody;
    private Animator anim;
    private SpriteRenderer sr;
    private Vector2 movementInput;
    private float movementX;
    public float playerSpeed = 2.0f;

    public PlayerInput playerInput;
    public InputAction pickUpInteract;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        
    }

     void OnMovement(InputValue value){
        movementInput = value.Get<Vector2>();
    }

    void FixedUpdate(){

        myBody.MovePosition(myBody.position + movementInput * playerSpeed * Time.fixedDeltaTime);
        AnimatePlayer();
    }

    public void AnimatePlayer(){
        movementX = Input.GetAxisRaw("Horizontal");
        if(movementX < 0){
            sr.flipX = true;
        } else  {
            sr.flipX = false;
        }
    }

    public void PickupInteract(InputAction.CallbackContext context)
    {
        Debug.Log("Interact");

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        pickUpInteract = playerInput.Player.Pickup_Interact;
        pickUpInteract.Enable();
    }

    private void OnDisable()
    {
        pickUpInteract.Disable();
    }
}
