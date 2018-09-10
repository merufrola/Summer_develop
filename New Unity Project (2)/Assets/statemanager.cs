using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statemanager : MonoBehaviour {

public static int state = 0;
public static int point = 0;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
if(point>5){
	//どんぐり
	state = 0;
}
else if(point>=5 && point<15){
	//うさぎ
	state = 1;
}
else if(point>=15 && point<35){
	//きつね
	state = 2;
}
else if(point>=35 && point<75){
	//おおかみ
	state = 3;
}
else if(point>=75 && point<155){
	//くま
	state = 4;
}
else if(point>=155 && point<1000){
	//ひと
	state = 5;
}
else if(point>=1000){
	//ゲーム終了
	state = 6;
}



	}
}
