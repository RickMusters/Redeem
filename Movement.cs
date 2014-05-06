using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float turnSpeed;
	public float horizontal = 0;
	public float vertical = 0;
	public float range = 1;
	public Transform right;
	public Transform up;
	public Transform down;
	public Transform left;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		float turn = Input.GetAxis("Horizontal");
		//Vector3 moveDirection = new Vector3(0,Input.GetAxis("Vertical"),0);
		//transform.Rotate(0,0,turn * -turnSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(0,-10,0);
			//transform.LookAt(worldPosition:90);
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(0,10,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(-10,0,0);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(10,0,0);
		}
	}
}
