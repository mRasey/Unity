using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	private float speed = 10.0f;
	private float nextFire = 0.0f;
	private float fireRate = 1.0f;
	public GameObject bulletPrefab;
	private Vector3 bulletPosition;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime * 2;
		rotation *= Time.deltaTime * 2;
		transform.Translate(0, translation, 0);
		transform.Translate (rotation, 0, 0);
		bulletPosition = transform.position;
		bulletPosition.x += 2.0f;
		bulletPosition.y -= 0.2f;
		if (Input.GetKeyDown(KeyCode.J)) {
			GameObject bullet = (GameObject)
				Instantiate (bulletPrefab, bulletPosition, Quaternion.identity);
		}
	}

	/*void OnCollisionEnter2D(Collision2D collision){
			Application.LoadLevel("gameOver");
	}*/

	void OnTriggerEnter2D(Collider2D collider){
		Application.LoadLevel ("gameOver");
	}

	void FixedUpdate(){

	}
}
