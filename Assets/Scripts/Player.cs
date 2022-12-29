using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string WALK_ANIMATION = "Walk";

    private bool isGrounded = true;

    private PlayerControllerInput playerInputController;
    private InputAction movement;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        playerInputController = new PlayerControllerInput();
        
    }

    private void OnEnable(){

        movement = playerInputController.Player.Movement;
        movement.Enable();

        playerInputController.Player.Jump.performed += doJump;
        playerInputController.Player.Jump.Enable();

    }

    private void OnDisable(){
        movement.Disable();
        playerInputController.Player.Jump.Disable();
    }

    private void doJump(InputAction.CallbackContext obj){

        if(Input.GetButtonDown("Jump") && isGrounded){
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
       
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    void AnimatePlayer() {

        if(movementX > 0){
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        } 
        else if(movementX < 0){
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
            else {
            anim.SetBool(WALK_ANIMATION, false);
        }        
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
        } else if(collision.gameObject.CompareTag("Monster")) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Monster")) {
            Destroy(gameObject);
        } 
    }
}
