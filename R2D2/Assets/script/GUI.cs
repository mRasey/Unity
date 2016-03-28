using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	//private GUILayoutOption glo;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		string content = "Score:" + text.Score;
		GUILayout.Label (content, GUILayout.Width(100));
		//GUILayout.Window(
	}
}
