using UnityEngine;
using System.Collections;

public class bulletPrefab : MonoBehaviour {
	public float speed = 0.5f;
	public float DestroyTime = 1.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy(gameObject);
	}
}
