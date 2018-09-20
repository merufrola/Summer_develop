﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class eat : MonoBehaviour {

public GameObject HMD ;
public GameObject Food;
Vector3 pos;

[SerializeField]
public GameObject usagi;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame

	void Update () {
		//フードセンサの位置をHMDのカメラ位置と連動させる
		pos = InputTracking.GetLocalPosition(XRNode.CenterEye);
			transform.position = new Vector3(pos.x,pos.y-2.5f,pos.z);
	}

	void OnTriggerEnter (Collider col) {

//センサに食べ物が当たった時の処理
	switch(col.gameObject.tag){

		case "hare":
				col.gameObject.SendMessage("damage");
		    statemanager.point = statemanager.point + 5;
			break;
		case "fox" :
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 10;
		break;
		case "wolf" :
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 20;
		break;
		case "bear" :
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 40;
		break;
		case "human" :
			col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 900;
		break;
		case "food" :
		col.gameObject.SendMessage("damage");
		statemanager.point = statemanager.point + 1;
		break;

	}
	}
}
