using UnityEngine;
using System.Collections;

public class ClickToShoot : MonoBehaviour {

	[HideInInspector]
	public BulletShooter BulletShooter;

	void Start () {
		BulletShooter = gameObject.GetComponent<BulletShooter> ();
	}

	void Update () {
		if (!BulletShooter)
			return;

		if(Input.GetKey(KeyCode.Mouse0))
		{
			BulletShooter.Shoot();
		}
	}
}
