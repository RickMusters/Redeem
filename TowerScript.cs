using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerScript : MonoBehaviour {

	// Use this for initialization
	private float rotationSpeed = 40f;
	public Transform child;
	public Transform target;
	public GameObject triggerZone;
	public static List<GameObject> Enemies = new List<GameObject>();

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		if(renderer.enabled)
		{

			//transform.Rotate(0,rotationSpeed * Time.deltaTime, 0);

		}
	}

	void OnMouseDown()
	{
		renderer.enabled = false;
		child.renderer.enabled = true;
		//lol.enabled = true;
	}

	/*void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Enemy")
		{
			transform.LookAt(target);
		}
	}*/
}
