using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public static bool attack = false;
	private bool removed = true;
	public GameObject sword;
	public float attackTime = 3f;
	public static Vector3 positions;
	public float destroyTime;
	private bool startTimer = false;
	public static Quaternion rotation;

	// Use this for initialization
	void Start()
	{
		positions.x = transform.position.x;
		//positions.y = transform.position.y;
		positions.z = transform.position.z;
	}
	// Update is called once per frame
	void FixedUpdate()
	{
		positions.x = transform.position.x;
		positions.y = transform.position.y;
		positions.z = transform.position.z;
		positions.z += 8;
		rotation = transform.rotation;

	}

	void Update () 
	{
		if(removed)
		{
			if(Input.GetKey(KeyCode.Space))
			{
				attack = true;
				removed = false;
			}
		}

		if(attack)
		{
			attack = false;
			GameObject temp;
			temp = Instantiate(sword,positions,Quaternion.identity) as GameObject;
			//temp.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
			temp.transform.Rotate (90,0,0);
			temp.AddComponent("Swordscript");
			startTimer = true;
			Destroy(temp,0.2f);
		}

		if(startTimer && destroyTime > 0)
		{
			destroyTime -= Time.deltaTime;
		}

		if(destroyTime <= 0)
		{
			startTimer = false;
			removed = true;
			destroyTime = 1f;
		}

		

	}
}
