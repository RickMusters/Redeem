using UnityEngine;
using System.Collections;

public class WaypointPath : MonoBehaviour {

	public int speed = 0;
	public GameObject[] waypoints;
	public GameObject target;
	private int waypoint = 0;

	void Start(){


		waypoints [0] = GameObject.Find ("path1/waypoint1.1");

		waypoints [1] = GameObject.Find("path1/tower1.2");
	
		waypoints [2] = GameObject.Find ("path1/waypoint1.3");

		target = GameObject.Find("level/temple");
	
	}

	void Update () {
		if (waypoint < waypoints.Length) {

			transform.Translate(Vector3.forward * speed * Time.deltaTime);

			if(Vector3.Distance(transform.position, waypoints[waypoint].transform.position)< 10){

				waypoint ++;
			}
		}

		if (waypoint == waypoints.Length) {

			transform.Translate (Vector3.zero);
			transform.LookAt(target.transform.position);

		} else {

			transform.LookAt(waypoints[waypoint].transform.position);
		}
		
		
	}
}
