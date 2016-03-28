using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public GameObject plane;
	public GameObject tank;
	public GameObject cloud;
	public GameObject mountain;
	private Vector3 planeLoc = Vector3.zero;
	private float nextPlane = 0.0f;
	private float planeRate;
	private Vector3 tankLoc = Vector3.zero;
	private Vector3 cloudLoc = Vector3.zero;
	private float nextCloud = 0.0f;
	private float cloudRate;
	private Vector3 mountainLoc = Vector3.zero;
	private float nextMount = 0.0f;
	private float mountRate;

	// Use this for initialization
	void Start () {
		//planeRate = Random.Range (2, 5);
		//cloudRate = Random.Range (6, 12);
		//mountRate = Random.Range (7, 13);
	}
	
	// Update is called once per frame
	void Update () {
		planeLoc.x = 10.0f;
		planeLoc.y = (float)Random.Range (-200, 430) / 100.0f;
		planeRate = Random.Range (1, 4);
		if (Time.time > nextPlane) {
			Instantiate (plane, planeLoc, Quaternion.identity);
			nextPlane = Time.time + planeRate;
		}

		cloudLoc.x = 15.0f;
		cloudLoc.y = (float)Random.Range (0, 430) / 100.0f;
		cloudRate = Random.Range (6, 12);
		if (Time.time > nextCloud) {
			Instantiate(cloud, cloudLoc, Quaternion.identity);
			nextCloud = Time.time + cloudRate;
		}

		mountainLoc.x = 10.0f;
		mountainLoc.y = -4.0f;
		mountRate = Random.Range (7, 13);
		if (Time.time > nextMount) {
			Instantiate(mountain, mountainLoc, Quaternion.identity);
			nextMount = Time.time + mountRate;
		}
	}
}
