using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	public GameObject camera;
	void Start () {
		if (PlayerPrefs.HasKey ("mute")) {
			if (PlayerPrefs.GetInt ("mute") == 0) {
				camera.GetComponent<AudioSource> ().mute = false;
			} else if (PlayerPrefs.GetInt ("mute") == 1){
				camera.GetComponent<AudioSource> ().mute = true;
			}
		} else {
			camera.GetComponent<AudioSource> ().mute = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
