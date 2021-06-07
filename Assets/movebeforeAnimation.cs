using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movebeforeAnimation : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float speed;
    bool isGrounded = false; 
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
    public int jumps;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 2f;
   
    void Start(){
        rb=GetComponent<Rigidbody2D>();
    }

    void Update(){
        OnGround();
        Move();
        Jump();
        BetterJump();
        if(Input.GetKeyDown(KeyCode.P)){
             SceneManager.LoadScene("level");
        }
    }
   
    void Move(){
        float x=Input.GetAxisRaw("Horizontal"); 
        rb.velocity=new Vector2(x*speed, rb.velocity.y);
    }
    
    void Jump(){
        if(Input.GetKeyDown(KeyCode.W)){
            if(isGrounded){
                jumps=0;
            }
            if(jumps<2){
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                jumps++;
            }
            
        }
    }
    
    void BetterJump() {
        if (rb.velocity.y < 0) {
            rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.W)) {
            rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }   
    }

    void OnGround(){
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); 
                if (collider != null) {
                    isGrounded = true; 
                }
                else { 
                    isGrounded = false; 
                } 
    }
    
}