using UnityEngine;
using System.Collections;

public class PipeControl : MonoBehaviour {

	public float pipeSpeed;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 5f);
		// Destroy this object 5 seconds after creation
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Vector3.right*Time.deltaTime*pipeSpeed);
	}
}
