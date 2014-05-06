using UnityEngine;
using System.Collections;

public class CameraTemple : MonoBehaviour 
{
	public Transform player;
	private float positionxMin;
	private float positionxMax;
	private float positionzMin;
	private float positionzMax;
	private bool beenInside = false;
	// Use this for initialization
	void Start () 
	{
		positionxMin = transform.position.x -100 * transform.lossyScale.x;
		positionxMax = transform.position.x +100 * transform.lossyScale.x;
		positionzMax = transform.position.z +100 * transform.lossyScale.z;
		positionzMin = transform.position.z -100 * transform.lossyScale.z;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(player.transform.position.x >positionxMin && player.transform.position.x <positionxMax && player.transform.position.z > positionzMin && player.transform.position.z < positionzMax)
		{
			beenInside = true;
			CameraMovement.distance = 300;
		}
		else
		{
			if(beenInside)
			{
				beenInside = false;
				CameraMovement.distance = 800;
			}
		}
	}
}
