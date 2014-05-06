using UnityEngine;
using System.Collections;

public class TowerAttack : MonoBehaviour 
{
	public Transform On;
	private bool enable = false;
	public GameObject bullet;
	public Transform spawnBullet;
	//public Transform endBullet;
	private float length;
	private float time = 1f;
	public bool shoot;
	private bool reloaded = false;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(On.renderer.enabled == false)
		{
			enable = true;
		}

		if(shoot && reloaded)
		{
			reloaded = false;
			GameObject clone;
			clone = Instantiate(bullet,spawnBullet.position,bullet.transform.rotation)as GameObject;
			//shoot = false;
		}

		if(enable && shoot)
		{
			time -= Time.deltaTime;
			if(time <= 0)
			{
				reloaded= true;
				time= 1f;
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{
		//Debug.Log ("lol");
		if(enable && col.collider.name == "Enemy")
		{
			shoot = true;
		}
		//Transform clone;
		//clone = Instantiate(bullet,transform.position,bulletRotation)as Transform;
		//clone.rigidbody.AddForce(transform.right);

	}

	void OnTriggerExit()
	{
		Debug.Log ("lol");
		if(enable)
		{
			shoot = false;
		}
	}

	void MoveObject (GameObject ThisTransform,Vector3 startPos, Vector3 endPos,float time)
	{
		float i = 0.0f;
		float rate = 1.0f/time;
		while (i < 1.0f) 
		{
			i += Time.deltaTime * rate;
			ThisTransform.transform.position = Vector3.Lerp(startPos, endPos, i); 
		}
	}
}
