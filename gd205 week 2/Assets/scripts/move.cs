using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public int playerX, playerZ;
	public GameObject textObject;
	// Use this for initialization
	void Start () {	
		//playerX = 5;
		//playerZ = 10000;
		//Debug.Log (transform.position);
		transform.position = new Vector3(playerX,0,playerZ);
		textObject.GetComponent<TextMesh> ().text = "test";
	}
	
	// Update is called once per frame
	void Update () {
		playerZ = (int)transform.position.z;
		playerX = (int)transform.position.x;

		if (Input.GetKeyDown ("up")) {
			transform.position += new Vector3 (0, 0, 1);
		}
		if (Input.GetKeyDown ("down")) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown ("left")) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown ("right")) {
			transform.position += new Vector3 (1, 0, 0);
		}

		textObject.GetComponent<TextMesh> ().text = "position: (" +
		transform.position.x + ", " +
		playerZ + ")";

		if (playerX == 0 && playerZ == 2) {//player is at the bad position
			Debug.Log ("reset the player's position");
		}

	}
}
