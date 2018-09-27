﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTest : MonoBehaviour {

    public AudioClip testSound;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown (0)) {
			audioSource.PlayOneShot (testSound);
		}
	}
}
