using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {
	public GameObject[] child;
	private GameObject clone;
	private GameObject[] queue;
	private int count;
	public Vector3 local;
	private Vector2 force;
	private Vector3 move;
	private float[] speed = {5.0f, 6.0f, 7.0f, 8.0f, 9.0f};
	private float moveSpeed = 1.0f;
	public static int Score;
	private bool firstSee = true;
	private bool canAdd = true;

	// Use this for initialization
	void Start () {
		Score = 0;
		count = 0;
		local = Vector3.zero;
		move = Vector3.zero;
		local.x = 10.0f;
		move.x = -1.0f;
		force.x = -10.0f;
		force.y = 0.0f;
		child = GameObject.FindGameObjectsWithTag ("army");
		StartCoroutine ("appear");
		//Instantiate(t, local, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		clone.transform.Translate (-(moveSpeed * Time.deltaTime * speed[Random.Range(0, speed.Length)]), 0.0f, 0.0f);
		//GameObject player = GameObject.FindGameObjectWithTag ("player");
		if (r2d2.pos - 10 > clone.transform.position.x && canAdd) {
			Score++;
			canAdd = false;
		}
		//queue = FindObjectsOfType
		/*for (int i = 0; i < count-1; i++) {
			if(queue[i] != null){
				queue[i].transform.Translate(-(moveSpeed * Time.deltaTime * 5.0f), 0, 0);
			}
		}
		for (int j = 0; j < count-1; j++) {
			if(queue[j].transform.position.x < 10.0f)
				Destroy(queue[j]);
		}*/

		/*queue = GameObject.FindGameObjectsWithTag("clone");
		for (int i = 0; i < queue.Length; i++) {
			queue[i].transform.Translate(-moveSpeed * Time.deltaTime * 5.0f, 0, 0);
			if(queue[i].transform.position.x < -10.0f)
				Destroy(queue[i]);
		}*/
	}

	IEnumerator appear(){
		for (;;) {
			clone = (GameObject)Instantiate (child[Random.Range(0, child.Length)], local, Quaternion.identity);
			canAdd = true;
			Destroy (clone, 5.0f);
			//clone.GetComponent<Rigidbody2D>().AddForce(force);
			//Score++;
			//queue[count++] = (GameObject)Instantiate(child[Random.Range(0, child.Length)], local, Quaternion.identity);
			//clone.tag = "clone";
			yield return new WaitForSeconds(5.0f);
		}
	}


}
