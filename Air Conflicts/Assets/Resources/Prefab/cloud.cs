using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {
	private float speed = -0.04f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
	}
}
