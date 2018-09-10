using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour {

public GameObject HMD ;
public GameObject Food;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = HMD.transform.position;
	}

	void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "food"){
			Debug.Log("ok");
			Destroy(Food);
		}
	}
}
