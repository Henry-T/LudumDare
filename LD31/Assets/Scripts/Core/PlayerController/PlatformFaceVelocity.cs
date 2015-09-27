using UnityEngine;
using System.Collections;

public class PlatformFaceVelocity : MonoBehaviour {

    private PlatformMoveController platformMoveController;

	// Use this for initialization
	void Start () {
        platformMoveController = gameObject.GetComponent<PlatformMoveController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!platformMoveController)
            return;

        //if (platformMoveController.Velocity.x > 0)
        //{
        //    gameObject.transform.rotation = Quaternion.identity;
        //}
        //else if(platformMoveController.Velocity.x < 0)
        //{
        //    gameObject.transform.rotation = Quaternion.EulerAngles(0, Mathf.PI, 0);
        //}
	}
}
