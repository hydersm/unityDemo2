using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour 
{
	private CoinCounter coinCounter;

	// Use this for initialization
	void Awake () 
	{
		coinCounter = GameObject.Find("coinText").GetComponent<CoinCounter>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			coinCounter.coinCount++;
			gameObject.SetActive(false);
		}
	}
}
