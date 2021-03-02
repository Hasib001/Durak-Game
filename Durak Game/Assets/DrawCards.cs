using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour {


	public GameObject card1;
	public GameObject card2;
	public GameObject playerArea;
	public GameObject aiArea;


	// Use this for initialization
	void Start () {
		
	}
	
	public void OnClick()
    {
		GameObject playerCard = Instantiate(card1, new Vector3(0, 0, 0), Quaternion.identity);
		playerCard.transform.SetParent(playerArea.transform, false);
	}
}
