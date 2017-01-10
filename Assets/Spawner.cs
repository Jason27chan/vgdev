using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public float timer;
	private float timerValue;

	public GameObject obstaclePrefab;

	// Use this for initialization
	void Start () {
		timerValue = timer;
	}
	
	// Update is called once per frame
	void Update () {
		timerValue -= Time.deltaTime;
		if (timerValue <= 0) {
			timerValue = timer;

			GameObject.Instantiate (obstaclePrefab, transform.position + Vector3.up * Random.Range (-5f, 5f), Quaternion.identity);
		}
	}
}
