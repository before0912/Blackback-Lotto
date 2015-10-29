using UnityEngine;
using System.Collections;

public class ClickSlaveGirl : MonoBehaviour {

	private ClickObject CO;
	private MainData MD;
	
	// Use this for initialization
	void Start () {
		CO = GetComponent<ClickObject>();
		MD = (GameObject.Find("/Main")).GetComponent<MainData>();
	}
	
	// Update is called once per frame
	void Update () {
		if (CO.isClick () == true) {
			if(MD.DCMoneySum >= LevelCache(MD.PlusLevel+1)){
				MD.PlusLevel++;
				MinusCache();
				DCPlusPercent();
			}
		}
	}

	void DCPlusPercent(){
		MD.DCPlusPercent = MD.PlusLevel * MD.PlusPercent;
	}
	
	double LevelCache(int level){
		float tm = (level) * MD.PlusPercent * System.Convert.ToSingle(MD.PlusPrice);
		return MD.PlusPrice + tm;
	}
	
	void MinusCache(){
		MD.DCMoneySum = MD.DCMoneySum - LevelCache(MD.PlusLevel);
	}
}
