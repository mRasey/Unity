using UnityEngine;
using System.Collections;

public class plane : MonoBehaviour {
	public GameObject bullet;
	public GameObject boom;
	private float speed = -0.05f;
	private float nextBullet = 1.0f;
	private float bulletRate = 3.0f;
	private Vector3 bulletLoc;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
		if (Time.time > nextBullet) {
			bulletLoc = transform.position;
			bulletLoc.x -= 1.5f; 
			Instantiate(bullet, bulletLoc, Quaternion.identity);
			nextBullet = Time.time + bulletRate;
		}
	}

	/*void OnCollisionEnter2D(Collision2D collision){
		//if (collision.gameObject.tag.Equals ("bullet")) {
			Destroy(gameObject);
			Instantiate(boom, transform.position, Quaternion.identity);
		//}
	}*/

	void OnTriggerEnter2D(Collider2D collider){
		Destroy(gameObject);
		Instantiate(boom, transform.position, Quaternion.identity);
	}
}
