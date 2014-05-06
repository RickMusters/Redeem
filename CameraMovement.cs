using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform target;
	public static float distance = 300;
	void Update () 
	{
		Vector3 temp = transform.position;
		temp.z = target.position.z -distance;
	
		temp.x = target.position.x;
		temp.y = target.position.y;
		//temp.z = transform.position.z;
		//temp.y = target.position.y;
		transform.position = temp;
	}
}
