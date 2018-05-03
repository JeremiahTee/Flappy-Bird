using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SmizeJump : MonoBehaviour {

	Rigidbody2D smize;
	public static int score;
	public Text scoreText;

	void Start () {
		score = 0;
		smize = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			smize.velocity = new Vector2(0, 3.5f);
		}

		scoreText.text = score.ToString ();
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "Obstacle") { //increase score as obstacle is passsed
			score++;
			return;
		}
	}

	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Pipes" || collision.gameObject.tag == "Ground") {
			Destroy (gameObject);
			PlayerPrefs.SetInt ("dead", 1); //1 for TRUE state
			SceneManager.LoadScene (0);
		}
	}
}
