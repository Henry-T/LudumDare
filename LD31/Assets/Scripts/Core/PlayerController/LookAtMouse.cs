using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		int layerMask = LayerMask.GetMask(new string[]{GameManager.Instance.LayerNameGround});
		RaycastHit hitInfo;
		if(Physics.Raycast(ray, out hitInfo, 100, layerMask))
		{
			Vector3 lookPos = new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z); 
			transform.LookAt (lookPos);
		}
	}
}
