using UnityEngine;
using System.Collections;

public class planeBullet : MonoBehaviour {
	private float speed = -0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy(gameObject);
	}
}
