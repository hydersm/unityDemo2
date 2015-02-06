using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour 
{
	public GUIText winText;

	// Use this for initialization
	void Awake () 
	{
		winText.enabled = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			winText.enabled = true;
		}
	}
}
