using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.x > 0 && transform.position.y < -100)
		{
			transform.Translate(new Vector3(-4,0,0));
		}

		if(transform.position.x > 400)
		{
			transform.Translate(new Vector3(4,0,0));
		}

		if(transform.position.x > 0 && transform.position.y > 200)
		{
			transform.Translate(new Vector3(-4,0,0));
		}

		if(transform.position.x < -100)
		{
			transform.Translate(new Vector3(-4,0,0));
		}

		Destroy(gameObject,1f);
	}
}
