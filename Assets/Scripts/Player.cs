using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D myBody;

    private Animator anim;

    private SpriteRenderer sr;

    private float movementX;

    [SerializeField]
    private float speed = 10f;


    private PlayerControllerInput playerInputController;

    private Vector2 move;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

        playerInputController = new PlayerControllerInput();
        
    }

    private void OnMovement(InputValue obj)
    {
        move = obj.Get<Vector2>();
        movementX = obj.Get<Vector2>().x;
    }

    void AnimatePlayer() {
        
        if(movementX > 0){
            sr.flipX = false;
        } 
        else if(movementX < 0){
            sr.flipX = true;
        }    
        
    }

    void FixedUpdate(){
        myBody.MovePosition(myBody.position + move * speed * Time.fixedDeltaTime);
        AnimatePlayer();
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
