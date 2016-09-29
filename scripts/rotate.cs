using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(Time.deltaTime, -5, 0);

		// ...also rotate around the World's Y axis
		transform.Rotate(5, Time.deltaTime, 10, Space.World);

		transform.RotateAround(Vector3.zero, Vector3.up, -40 * Time.deltaTime);
	}
}
