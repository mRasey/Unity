using UnityEngine;
using System.Collections;

public class tryAgain : MonoBehaviour {
	private KeyCode click = KeyCode.Mouse0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(click)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if(Physics.Raycast(ray,out hitInfo)){
				GameObject gameObj = hitInfo.transform.gameObject;
				if(gameObj.transform.tag.Equals("tryAgain")){
					Application.LoadLevel("game");
				}
			}
		}

	}
}
