using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlappyBirdControl : MonoBehaviour {

	public float jumpVelocity;

	public Texture scoreText;
	private int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			//GetComponent<Transform>().
			//GetComponent<Rigidbody>().AddForce(new Vector3(0,1,0));
			GetComponent<Rigidbody>().AddForce(Vector3.up*jumpVelocity, ForceMode.VelocityChange);
		}
		score = ((int)Time.timeSinceLevelLoad);
		//scoreText.GetNativeTextureID = score.ToString ();
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals ("Respawn")) {
			SceneManager.LoadScene (0);
		}
	}
}
