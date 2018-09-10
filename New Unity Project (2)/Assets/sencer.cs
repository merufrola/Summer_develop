using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sencer : MonoBehaviour {
public GameObject HMD ;
Vector3 pos;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		pos = HMD.transform.position;
		pos.y += 0.7f;
		transform.position = pos;
	}

	void OnTriggerEnter(){
		case "hare":

		case "fox" :

		case "wolf" :

		case "bear" :

		case "human" :

		case "food" :
		// GameOver処理
		break;

	}
}
