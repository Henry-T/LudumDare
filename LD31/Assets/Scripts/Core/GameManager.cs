﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public string LayerNameGround = "ground";
    public string LayerNameEnemy = "enemy";

	void Start () {
		Instance = this;
	}

	void Update () {
	
	}
}
