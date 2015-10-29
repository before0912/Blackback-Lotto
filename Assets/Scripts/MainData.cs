using UnityEngine;
using System.Collections;

public class MainData : MonoBehaviour {

	public TextSetting TS;
	public GameObject win_ground;
	public GameObject win_slave;


	public double DCMoney;	// 총 당첨금


	public float DCGuanPercent;	// 관직 총 뻥튀기
	public float DCGroundPercent;	// 부동산 총 뻥튀기
	public float DCPlusPercent;		// 여 노비 총 뻥튀기


	public double[] GroundPriceItem;
	public float[] GroundPercentItem;
	public double GuanPrice;	// 관직 레벨당 구입금액
	public float GuanPercent;	// 관직 레벨당 추가금액 배율
	public float PlusPrice;		// 여 노비 레벨당 구입금액
	public float PlusPercent;	// 여 노비 레벨당 추가금액 배율
	public int SpeedLevel;		// 남 노비 속도
	public int SpeedPrice;		// 남 노비 구입금액

	// 디비 저장
	public double DCMoneySum;	// 총 보유금액
	public int[] GroundStateItem;	// 부동산 구입여부
	public double[] NCarr = {0,0,0,0,0,0,0};		// 등수별 당첨 횟수
	public double[] DCMoneyArr = {0,0,0,0,0,0,0};	// 등수별 당첨금 합계
	public double[] DCMoneyArrNoSum = {0,0,0,0,0,0,0};	// 등수별 당첨금
	public int PlusLevel;		// 뻥튀기 노비 레벨
	public int GuanLevel;		// 관직 레벨
	public double timesCount;		// 응모 횟수
	// 디비 저장 /
		
	public bool win_tog;
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
		GroundPriceItem = new double[]{1000000,5000000,10000000,50000000,100000000,500000000,1000000000,5000000000};
		GroundPercentItem = new float[]{1f,2f,3f,4f,5f,6f,7f,8f};
		GroundStateItem = new int[]{-1,-1,-1,-1,-1,-1,-1,-1};

		GuanPrice = 1000000;	// 관직 레벨당 구입금액
		GuanPercent = 1f;	// 관직 레벨당 추가금액 배율
		PlusPrice = 100000;		// 여 노비 레벨당 구입금액
		PlusPercent = 0.1f;	// 여 노비 레벨당 추가금액 배율
		SpeedLevel = 1;		// 남 노비 기본속도
		SpeedPrice = 10000000;		// 남 노비 구입금액
	}

}
