using UnityEngine;
using System.Collections;

public class LottoLogic : MonoBehaviour {

	private MainData MD;

	// Use this for initialization
	void Start () {
		MD = (GameObject.Find("/Main")).GetComponent<MainData>();
	}
	
	
	string djr(int n){
		return n > 9 ? "" + n: "0" + n;
	}
	
	public string getNumber(string[] arr){
		string rtn = null;
		for (int h=0; h<1000; h++) {
			string num = djr (Random.Range (1, 45));
			if(System.Array.IndexOf(arr,num) == -1){
				rtn = num;
				break;
			}
		}
		return rtn;
	}
	
	public string[] getNumberArray(){
		string[] arr = {"","","","","",""};
		for (int i=0; i<6; i++) {
			arr [i] = getNumber (arr);
		}
		System.Array.Sort (arr);
		return arr;
	}
	
	public double PlusCache(double cache){
		float tm = MD.PlusLevel / 10f * System.Convert.ToSingle(cache);
		float tm2 = MD.GuanLevel / 1f * System.Convert.ToSingle(cache);
		return cache + tm + tm2;
	}
	
	public int isDangchum(string[] arr1,string[] arr2){
		int cnt = 0;
		int rank = 0;

		MD.DCMoneyArrNoSum[1] = PlusCache(MD.DCMoney / 100 * 75) ;
		MD.DCMoneyArrNoSum[2] = PlusCache(MD.DCMoney / 1000 * 125 / 30);
		MD.DCMoneyArrNoSum[3] = PlusCache(MD.DCMoney / 1000 * 125 / 1500);
		MD.DCMoneyArrNoSum[4] = PlusCache(50000);
		MD.DCMoneyArrNoSum[5] = PlusCache(5000);
		
		
		for(var i=0;i<arr2.Length;i++){
			if(System.Array.IndexOf(arr1,arr2[i]) != -1){
				cnt++;
			}
		}
		if (cnt == 6) {	// 1st
			rank = 1;
			MD.DCMoneyArr[rank] += MD.DCMoneyArrNoSum[rank];
		} else if (cnt == 5) {	// 3st
			
			if(System.Array.IndexOf(arr2,MD.num1bonus) != -1){
				rank = 2;
				MD.DCMoneyArr[rank] += MD.DCMoneyArrNoSum[rank];
			}else{
				rank = 3;
				MD.DCMoneyArr[rank] += MD.DCMoneyArrNoSum[rank];
			}
		} else if (cnt == 4) {	// 4st
			rank = 4;
			MD.DCMoneyArr[rank] += MD.DCMoneyArrNoSum[rank];
		} else if (cnt == 3) {	// 5st
			rank = 5;
			MD.DCMoneyArr[rank] += MD.DCMoneyArrNoSum[rank];
		}

		
		if (rank > 0) {
			MD.NCarr [rank]++;
		}
		return rank;
	}


}
