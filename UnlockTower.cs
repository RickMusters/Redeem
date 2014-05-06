using UnityEngine;
using System.Collections;

public class UnlockTower : MonoBehaviour 
{
	//public static bool TowerOn = false;
	void Start()
	{
	}

	void OnMouseDown()
	{
		renderer.enabled = false;
	}
}
