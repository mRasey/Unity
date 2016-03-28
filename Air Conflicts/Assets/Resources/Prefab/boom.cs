using UnityEngine;
using System.Collections;

public class boom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {

	}

	/*void OnCollisionEnter2D(Collision2D collision){
		Destroy (gameObject);
	}*/

	/*void OnTriggerEnter2D(Collider2D collider){
		Destroy(gameObject);
	}*/
}
