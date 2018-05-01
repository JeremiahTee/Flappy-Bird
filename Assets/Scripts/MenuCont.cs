using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuCont : MonoBehaviour {

	public GameObject playButton;
	public Button SoundButton;
	public GameObject camera;
	public Text welcome;
	// Use this for initialization
	void Start () {
		//handle muting option
		if (PlayerPrefs.HasKey ("mute")) {
			if (PlayerPrefs.GetInt ("mute") == 0) {
				camera.GetComponent<AudioSource> ().mute = false;
			} else if (PlayerPrefs.GetInt ("mute") == 1){
				camera.GetComponent<AudioSource> ().mute = true;
			}
		} else {
			camera.GetComponent<AudioSource> ().mute = false;
		}

		//handle welcome text at beginning
		if (PlayerPrefs.HasKey ("mute")) {
			if (PlayerPrefs.GetInt ("dead") == 1) {
				welcome.text = " get good, you scrub";
			}
		}
	}

	public void PlayGame(){
		SceneManager.LoadScene (1);
	}

	public void MuteSound(){
		if (camera.GetComponent<AudioSource> ().mute) {
			camera.GetComponent<AudioSource> ().mute = false;
			PlayerPrefs.SetInt ("mute", 0); //sound is unmuted
		} else {
			camera.GetComponent<AudioSource> ().mute = true;
			PlayerPrefs.SetInt ("mute", 1); //sound is muted
		}
	}
}
