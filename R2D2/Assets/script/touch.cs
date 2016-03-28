using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour {
	public static float pos;
	public float speed = 0.1f;
	public float height = 1.0f;
	public KeyCode jump = KeyCode.Space;
	private Vector3 move = Vector3.zero;
	private Vector2 force = Vector2.zero;
	private bool canJump = true;
	private float pushTime = 0.0f;
	private float startPush = 0.0f;
	private float endPush = 0.0f;
	private bool readyJump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(jump)){
			transform.Translate(0, height, 0);
			//move.y = height;
			//controller.Move(move);
		}*/
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag.Equals("land")){
			canJump = true;
		}
		if(collision.gameObject.tag.Equals("end")){
			Application.LoadLevel("gameOver");
		}
	}
	
	void FixedUpdate(){
		if (Input.touchCount > 0 && !readyJump) {
			startPush = Time.time;
			readyJump = true;
			//canJump = false;
		}
		if (Input.touchCount == 0 && readyJump) {
			endPush = Time.time;
			force.y = 1000.0f * (Mathf.Sqrt(endPush - startPush));
			//startPush = endPush;
			if(canJump) {
				GetComponent<Rigidbody2D> ().AddForce (force);
				canJump = false;
				readyJump = false;
			}
		}
	}
}
