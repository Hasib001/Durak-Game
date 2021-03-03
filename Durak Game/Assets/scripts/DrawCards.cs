using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour {


	public GameObject card1;
	public GameObject card2;
	public GameObject card3;
	public GameObject card4;
	public GameObject card5;
	public GameObject card6;
	public GameObject playerArea;
	public GameObject aiArea;


	// Use this for initialization
	void Start () {
        Debug.Log("Start");
		//card1.GetComponent<Renderer>().enabled = false;
		card1.SetActive(false);
		card2.SetActive(false);
		card3.SetActive(false);
		card4.SetActive(false);
		card5.SetActive(false);
		card6.SetActive(false);

		//card1.transform.SetParent(aiArea.transform, false);
	}

	public void OnClick()
    {
		Debug.Log("clicked");
		//GameObject playerCard = Instantiate(card1, new Vector3(0, 0, 0), Quaternion.identity);
		//playerCard.transform.SetParent(aiArea.transform, false);
		card1.SetActive(true);
		card1.SetActive(true);
		card2.SetActive(true);
		card3.SetActive(true);
		card4.SetActive(true);
		card5.SetActive(true);
		card6.SetActive(true);

	}
}
