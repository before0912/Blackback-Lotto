using UnityEngine;
using System.Collections;

public class ClickSlaveMan : MonoBehaviour {

	private ClickObject CO;
	private MainData MD;

	private bool tog;
	public float dt;
	
	// Use this for initialization
	void Start () {
		CO = GetComponent<ClickObject>();
		MD = (GameObject.Find("/Main")).GetComponent<MainData>();
		tog = false;
		dt = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (tog == false) {
			if (CO.isClick () == true) {
				if (MD.DCMoneySum >= MD.SpeedPrice) {
					MD.SpeedLevel = 30;
					MinusCache ();
					tog = true;
				}
			}
		} else {
			dt += Time.deltaTime;
			if(dt >= 600f){
				dt = 0f;
				tog = false;
				MD.SpeedLevel = 1;
			}
		}
	}
	
	void MinusCache(){
		MD.DCMoneySum = MD.DCMoneySum - MD.SpeedPrice;
	}
}
