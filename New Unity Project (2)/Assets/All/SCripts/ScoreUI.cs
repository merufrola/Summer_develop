﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    public Text targetText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        this.targetText.text = "Score : " + statemanager.point;
	}
}
