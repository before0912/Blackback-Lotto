using UnityEngine;
using System.Collections;

public class win_ground : MonoBehaviour {
	
	private MainData MD;
	public GameObject[] Blanks;

	// Use this for initialization
	void Start () {
		MD = (GameObject.Find("/Main")).GetComponent<MainData>();
	}
	
	// Update is called once per frame
	void Update () {
		transBlankState ();
	}

	void resClickItem(int itemNumber)
	{

		if(MD.GroundStateItem [itemNumber] == -1){
			if(Purchase (itemNumber)) MD.GroundStateItem [itemNumber] = MD.GroundStateItem [itemNumber] * -1;
		}
		else if(MD.GroundStateItem [itemNumber] == 1){
			if(Sale (itemNumber)) MD.GroundStateItem [itemNumber] = MD.GroundStateItem [itemNumber] * -1;
		}

		transBlankState ();

		DCGroundPercent ();

	}

	void resClickBlank(int itemNumber)
	{
		resClickItem (itemNumber);
	}

	public void transBlankState()
	{
		for (int i=0; i<MD.GroundStateItem.Length; i++) 
		{
			if(MD.GroundStateItem[i] == -1) Blanks[i].gameObject.SetActive(false);
			else  Blanks[i].gameObject.SetActive(true);
		}
	}

	bool Purchase(int itemNumber){	// 구입
		if (MD.DCMoneySum >= MD.GroundPriceItem [itemNumber]) {
			Debug.Log ("p true");
			MD.DCMoneySum -= MD.GroundPriceItem [itemNumber];
			return true;
		} else {
			Debug.Log ("p false");
			return false;
		}

	}

	bool Sale(int itemNumber){		//	판매
		MD.DCMoneySum += MD.GroundPriceItem [itemNumber];
		Debug.Log ("s true");
		return true;
	}

	void DCGroundPercent(){
		float tm = 0f;
		for (int i=0; i<MD.GroundStateItem.Length; i++) 
		{
			if(MD.GroundStateItem[i] == 1){
				tm += MD.GroundPercentItem[i];
			}
		}

		MD.DCGroundPercent = tm;
	}
}
