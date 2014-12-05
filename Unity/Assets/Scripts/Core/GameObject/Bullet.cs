using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float Speed;

	void Start () {
		
	}

	void Update () {
		transform.position += transform.forward * Speed;
	}
}
