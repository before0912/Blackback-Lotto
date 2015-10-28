using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	private TextSetting TS;
	private MainData MD;
	private LottoLogic LL;

	private int NC = 0;
	private float tt = 0f;

	// Use this for initialization
	void Start () {
		MD = GetComponent<MainData>();
		TS = MD.TS;
		LL = GetComponent<LottoLogic> ();
	}
	
	// Update is called once per frame
	void Update () {
		tt += Time.deltaTime;
		if (tt >= (1f-(0.033f*MD.SpeedLevel))) {
			GoGo ();
			tt = 0f;
		}
	}

	public void GoGo()
	{
		firstDisplay ();
		secondDisplay ();
		thirdDisplay ();
	}



	void firstDisplay(){
		MD.timesCount++;
		TS.Times.text = string.Format("{0,8:N0}",MD.timesCount);
		//TS.Times.text = "제 "+string.Format("{0,0:N6}",tt)+" 회 추첨";
		
		MD.num1arr = LL.getNumberArray ();
		MD.num1str = string.Join (" ", MD.num1arr);
		MD.num1bonus = LL.getNumber (MD.num1arr);
		//TS.Num1.text = MD.num1str+" : "+MD.num1bonus;

		MD.num2arr = LL.getNumberArray ();
		MD.num2str = string.Join (" ", MD.num2arr);
		//TS.Num2.text = MD.num2str;
	}

	void secondDisplay(){
		NC = LL.isDangchum (MD.num1arr,MD.num2arr);
		if (NC == 1) {	// 1st
			TS.Num1.text = MD.num1str+" : "+MD.num1bonus;
			//TS.DC1.text = secondDisplayText(1);
		} else if (NC == 2) {	// 2st
			TS.Num2.text = MD.num1str+" : "+MD.num1bonus;
			//TS.DC2.text = secondDisplayText(2);
		} else if (NC == 3) {	// 3st
			//TS.DC3.text = secondDisplayText(3);
		} else if (NC == 4) {	// 4st
			//TS.DC4.text = secondDisplayText(4);
		} else if (NC == 5) {	// 5st
			//TS.DC5.text = secondDisplayText(5);
		}

		double[] DCMoneyArr = MD.DCMoneyArr;
		double sum = DCMoneyArr[1]+DCMoneyArr[2]+DCMoneyArr[3]+DCMoneyArr[4]+DCMoneyArr[5]+DCMoneyArr[6];
		TS.MoneySum.text = "돈 "+string.Format("{0,0:N0}", sum)+"원";
	}

	string secondDisplayText(int n){
		//return MD.num2str+"  "+string.Format("{0,0:N0}", MD.NCarr[NC])+"회";
		return string.Format ("{0,11:N0}", MD.DCMoneyArrNoSum[n]);
	}

	void thirdDisplay(){
		TS.DC1.text = secondDisplayText (1);
		TS.DC2.text = secondDisplayText (2);
		TS.DC3.text = secondDisplayText (3);
		TS.DC4.text = secondDisplayText (4);
		TS.DC5.text = secondDisplayText (5);
	}

	

	public void closeAllWindows(){
		MD.win_ground.gameObject.SetActive (false);
		MD.win_slave.gameObject.SetActive (false);
	}

}
