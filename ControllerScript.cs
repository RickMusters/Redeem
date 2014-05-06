using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour {

	public float speed;
	public float runspeed;
	public float walkspeed;
	public float jumpSpeed;
	public float gravity;
	public float turnSpeed;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	private float curSpeed;
	void Start()
	{

	}
	void Update() 
	{
		controller = GetComponent<CharacterController>();
		speed = walkspeed;
		if (controller.isGrounded) 
		{
			if(Input.GetKey("right cmd"))
			{
				speed = runspeed;
			}
			moveDirection = new Vector2(0,Input.GetAxis("Vertical"));
			//moveDirection = new Vector2(0, 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			float turn = Input.GetAxis("Horizontal");
			moveDirection *= speed;
			//transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			transform.Rotate(0,0,turn * turnSpeed * Time.deltaTime);
			//Vector3 forward = transform.TransformDirection(Vector3.forward);
			//curSpeed = speed * Input.GetAxis("Vertical");
			//if (Input.GetButton("Jump"))
			//{
			//	moveDirection.y = jumpSpeed;
			//}

		}

		//controller.SimpleMove(moveDirection * curSpeed);
		//moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
		//controller.SimpleMove(moveDirection*Time.deltaTime * 10000);
	}
}
