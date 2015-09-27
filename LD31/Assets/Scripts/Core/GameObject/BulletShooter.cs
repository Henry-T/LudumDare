using UnityEngine;
using System.Collections;

public class BulletShooter : MonoBehaviour {

	public Bullet BulletPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shoot()
	{
		Bullet bulletObj = (GameObject.Instantiate (BulletPrefab) as Bullet);
		if (bulletObj) {
						// Bullet bullet = bulletObj.GetComponent<Bullet> ();
			bulletObj.transform.forward = transform.forward;
			bulletObj.transform.position = transform.position;
				}
	}
}
