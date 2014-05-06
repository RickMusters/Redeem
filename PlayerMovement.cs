using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int moveSpeed;

	public Animator anim;

	void Start()
	{
		anim.GetComponent<Animator>();
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.D))
		{
			anim.SetBool("MoveRight",true);
		}

		if(Input.GetKeyUp(KeyCode.D))
		{
			anim.SetBool("MoveRight",false);
		}

		if(Input.GetKeyDown(KeyCode.A))
		{
			anim.SetBool("MoveLeft",true);
		}
		
		if(Input.GetKeyUp(KeyCode.A))
		{
			anim.SetBool("MoveLeft",false);
		}

		if(Input.GetKeyDown(KeyCode.W))
		{
			anim.SetBool("MoveUp",true);
		}
		
		if(Input.GetKeyUp(KeyCode.W))
		{
			anim.SetBool("MoveUp",false);
		}

		if(Input.GetKeyDown(KeyCode.S))
		{
			anim.SetBool("MoveDown",true);
		}
		
		if(Input.GetKeyUp(KeyCode.S))
		{
			anim.SetBool("MoveDown",false);
		}

		if(Input.GetKey(KeyCode.S))
		{
			rigidbody.AddForce(0,-moveSpeed,0);
			anim.SetBool("WalkDown",true);
			anim.SetBool("WalkRight",false);
			anim.SetBool("WalkLeft",false);
			anim.SetBool("WalkUp",false);

		}
		if(Input.GetKey(KeyCode.W))
		{
			rigidbody.AddForce(0,moveSpeed,0);
			anim.SetBool("WalkUp",true);
			anim.SetBool("WalkLeft",false);
			anim.SetBool("WalkRight",false);
			anim.SetBool("WalkDown",false);
		}
		if(Input.GetKey(KeyCode.A))
		{
			rigidbody.AddForce(-moveSpeed,0,0);
			anim.SetBool("WalkLeft",true);
			anim.SetBool("WalkDown",false);
			anim.SetBool("WalkRight",false);
			anim.SetBool("WalkUp",false);
		}
		if(Input.GetKey(KeyCode.D))
		{
			rigidbody.AddForce(moveSpeed,0,0);
			anim.SetBool("WalkRight",true);
			anim.SetBool("WalkDown",false);
			anim.SetBool("WalkLeft",false);
			anim.SetBool("WalkUp",false);
		}


	}
}
