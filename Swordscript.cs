using UnityEngine;
using System.Collections;

public class Swordscript : MonoBehaviour {
	public static bool attack = false;
	private bool removed = true;
	public float destroyTime;
	private bool startTimer = false;
	// Use this for initialization
	
	// Update is called once per frame
	void Start()
	{
		renderer.enabled = false;
	}
	void Update () 
	{
		//PlayerAttack.positions.z += 8;
		//Vector3 tempPosition = PlayerAttack.positions;
		//Quaternion tempRotation = PlayerAttack.rotation;
		//transform.position = tempPosition;
		//transform.rotation = PlayerAttack.rotation;
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
			renderer.enabled = true;
			startTimer = true;
		}

		if(startTimer && destroyTime > 0)
		{
			destroyTime -= Time.deltaTime;
		}
		
		if(destroyTime <= 0)
		{
			startTimer = false;
			removed = true;
			renderer.enabled = false;
			destroyTime = 1f;
		}
	}

	void FixedUpdate()
	{

	}
}
