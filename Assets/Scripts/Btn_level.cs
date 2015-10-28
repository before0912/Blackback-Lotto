using UnityEngine;
using System.Collections;

public class Btn_level : MonoBehaviour {
	
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
			MD.GuanLevel++;
			MD.TS.GuanLevel_text.text = "" + MD.GuanLevel;
		}
	}
}
