using UnityEngine;
using System.Collections;

public class MainData : MonoBehaviour {

	public TextSetting TS;
	public GameObject win_ground;
	public GameObject win_slave;


	public double DCMoney;	// 총 금액
	public int[] GroundStateItem = {-1,-1,-1,-1,-1,-1,-1,-1};
	public int[] GroundPriceItem = {1000000,5000000,10000000,50000000,10000000,50000000,10000000,50000000};
	public double[] NCarr = {0,0,0,0,0,0,0};
	public double[] DCMoneyArr = {0,0,0,0,0,0,0};	// 등수별 당첨금 합계
	public double[] DCMoneyArrNoSum = {0,0,0,0,0,0,0};	// 등수별 당첨금

	public int SpeedLevel = 0;		// 속도
	public int PlusLevel = 0;		// 뻥튀기 노비 레벨
	public int GuanLevel = 0;		// 관직 레벨

	
	public bool win_tog;
	
	public double timesCount = 0;
	public string[] num1arr = {"","","","","",""};
	public string[] num2arr = {"","","","","",""};
	public string num1str = "";
	public string num2str = "";
	public string num1bonus = "";
	

	void Start () {
		//TS = GetComponent<TextSetting>();
		//win_ground = GameObject.Find("/Madang/win_ground");
		//win_slave = GameObject.Find("/Madang/win_slave");
		DCMoney = 16000000000;
		win_tog = false;
	}

}
