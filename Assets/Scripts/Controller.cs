using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject obs1, obs2, obs3, obs4, PositionNewObstacle;
	private int counter = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnTriggerEnter2D(Collider2D collision){
		counter = Random.Range (1, 5);
		if (collision.gameObject.tag == "Obstacle") {
			switch (counter) {
			case 1:
				//create a clone of obs1 and add it to location of new obstacle
				Instantiate (obs1, new Vector2(PositionNewObstacle.transform.position.x, obs1.transform.position.y), Quaternion.identity);
				break;
			case 2:
				Instantiate (obs2, new Vector2(PositionNewObstacle.transform.position.x, obs2.transform.position.y), Quaternion.identity);
				break;
			case 3:
				Instantiate (obs3, new Vector2(PositionNewObstacle.transform.position.x, obs3.transform.position.y), Quaternion.identity);
				break;
			case 4:
				Instantiate (obs4, new Vector2(PositionNewObstacle.transform.position.x, obs4.transform.position.y), Quaternion.identity);
				break;
			}
				
		Destroy (collision.gameObject);
		}
	}
}
