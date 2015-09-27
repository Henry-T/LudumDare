using UnityEngine;
using System.Collections;

public class MoveController1 : MonoBehaviour {

	public float MoveSpeed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = Vector3.zero;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			velocity = new Vector3(-1, 0, 0);
		}
		else if (Input.GetKey(KeyCode.RightArrow)) {
			velocity = new Vector3(1, 0, 0);
		}
		else if (Input.GetKey(KeyCode.UpArrow)) {
			velocity = new Vector3(0, 0, 1);
		}
		else if (Input.GetKey(KeyCode.DownArrow)) {
			velocity = new Vector3(0, 0, -1);
		}

		velocity *= MoveSpeed;

		transform.position += Time.deltaTime * velocity;
	}
}
