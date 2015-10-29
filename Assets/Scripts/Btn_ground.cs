using UnityEngine;
using System.Collections;

public class Btn_ground : MonoBehaviour {

	private ClickObject CO;
	private main Main;
	private MainData MD;

	// Use this for initialization
	void Start () {
		CO = GetComponent<ClickObject>();
		Main = (GameObject.Find("/Main")).GetComponent<main>();
		MD = (GameObject.Find("/Main")).GetComponent<MainData>();
	}
	
	// Update is called once per frame
	void Update () {
		if (CO.isClick () == true) {
			Main.closeAllWindows ();
			MD.win_ground.gameObject.SetActive (true);
			/*
			if (MD.win_tog == false) {
				MD.win_tog =true;
				MD.win_ground.gameObject.SetActive (MD.win_tog);
			} else {
				MD.win_tog = false;
			}
			*/
		}
	}
}
