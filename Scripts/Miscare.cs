using UnityEngine;
using System.Collections;

public class Miscare : MonoBehaviour {


	public float maxSpeed=7f;
	public float jumpforce=350f;
	public bool grounded=false, grounded1=false;
	public Transform groundCheck;
	public Transform LavaCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround, Lava;

	void FixedUpdate () {
	float move = Input.GetAxis("Horizontal");
	rigidbody2D.velocity = new Vector2(move*maxSpeed, rigidbody2D.velocity.y);
	
	
	grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
	grounded1= Physics2D.OverlapCircle(LavaCheck.position, groundRadius, Lava);
	}
	
	void Update()
	{
	if(grounded&&Input.GetKeyDown(KeyCode.Space))
	{
		rigidbody2D.AddForce(new Vector2(0,jumpforce )); 
		
	}
	
	if(grounded1==true) Application.Quit();
	}
	
	
	

}

