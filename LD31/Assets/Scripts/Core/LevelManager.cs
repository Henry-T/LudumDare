using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    
    public static LevelManager Instance;

	// Use this for initialization
	void Start () {
        Instance = this;
        StartCoroutine("spawn");
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SpawnEnemy(string typeName, Vector3 position) {
        var prefab = Resources.Load("Enemy");
        GameObject obj = GameObject.Instantiate(prefab) as GameObject;
        
    }

    IEnumerator spawn()
    {
        while(true)
        {
            yield return null;
            SpawnEnemy("", new Vector3(-1, 0, 0));
            yield return new WaitForSeconds(2f);
        }
    }
}
