using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class CoinCounter : MonoBehaviour 
{
	private int coinCount = 0;
	
	// Update is called once per frame
	void Start () 
	{
		guiText.text = "x" + coinCount;
	}

	public int getCoinCount(){
		return coinCount;
	}

	public void setCointCount(int num){
		coinCount = num;
		guiText.text = "x" + coinCount;
	}
}
