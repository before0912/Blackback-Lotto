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
			if(MD.DCMoneySum >= LevelCache(MD.GuanLevel+1)){
				Main.closeAllWindows ();
				MD.GuanLevel++;
				MinusCache();
				DCGuanPercent();
				MD.TS.GuanLevel_text.text = "" + MD.GuanLevel;
			}
		}
	}

	void DCGuanPercent(){
		MD.DCGuanPercent = MD.GuanLevel * MD.GuanPercent;
	}

	double LevelCache(int level){
		float tm = (level) * MD.GuanPercent * System.Convert.ToSingle(MD.GuanPrice);
		return MD.GuanPrice + tm;
	}
	
	void MinusCache(){
		MD.DCMoneySum = MD.DCMoneySum - LevelCache(MD.GuanLevel);
	}

}
