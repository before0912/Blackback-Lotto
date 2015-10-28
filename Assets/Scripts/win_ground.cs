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
		if (itemNumber > 0)
			itemNumber--;
		MD.GroundStateItem [itemNumber] = MD.GroundStateItem [itemNumber] * -1;
		transBlankState ();
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
}
