using UnityEngine;
using System.Collections;

public class TowerRange : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Enemy")
		{
			//TowerScript.Enemies.Add(other.gameObject);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.gameObject.name == "Enemy")
		{

		}
	}
}
