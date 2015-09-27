using UnityEngine;
using System.Collections;

public class AnimatorEventDispatcher : MonoBehaviour {

    public IAnimatorEventListener Listener;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DispatchEvent(string name)
    {
        if(Listener != null)
        {
            Listener.HandleEvent(name);
        }
    }
}
