using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScripManager : MonoBehaviour {
public Text text1;
public Text text2;
public Text text3;
public Text text4;

	// Use this for initialization
	void Start () {
		if(statemanager.state>5){
			text1.text = "Game Complete!";
		}else{
			text1.text = "Game Ovre!";
		}

		text2.text = "point：" + statemanager.point;
		text3.text = "Retry?";

	}

	// Update is called once per frame
	void Update () {


	}

	void TextManager(){








	}
}
