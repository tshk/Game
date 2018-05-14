using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour {
    
    public float SpeedValue;
    public float JumpValue;

    private Rigidbody2D customRigidBody2D;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D customCollider2D;

    private Animator customAnimator;

	// Use this for initialization
	void Start () {
        customRigidBody2D = GetComponent<Rigidbody2D>();

        customCollider2D = GetComponent<Collider2D>();

        customAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(customCollider2D, whatIsGround);

        customRigidBody2D.velocity = new Vector2(SpeedValue, customRigidBody2D.velocity.y);

        //if (Input.GetButtonDown(""))
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
            customRigidBody2D.velocity = new Vector2(customRigidBody2D.velocity.x, JumpValue); 
        }
        customAnimator.SetFloat("Speed", customRigidBody2D.velocity.x);
        customAnimator.SetBool("Grounded", grounded);
	}
}
