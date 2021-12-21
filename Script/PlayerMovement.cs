using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;

    bool jump = false;
    bool crouch = false;

    private Vector3 startingPoint;
    public GameObject FallDetector;
    [SerializeField] private AudioClip jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        startingPoint = transform.position; 
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));       


        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("IsJumping",true);
            SoundManager.instance.PlaySound(jumpSound);
            
        }
        if (Input.GetButtonDown("Crouch")) {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
        }

    }
    public void OnLanding() {
        animator.SetBool("IsJumping",false);
    }
    public void OnCrouching(bool isCrouching) {
        animator.SetBool("IsCrouching",isCrouching);
    }
    void FixedUpdate() {
        //Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
