using UnityEngine;
using System.Collections;

public class barrier : MonoBehaviour {
	public float moveSpeed = 1.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-(moveSpeed * Time.deltaTime * 3.0f), 0, 0);
	}
}
