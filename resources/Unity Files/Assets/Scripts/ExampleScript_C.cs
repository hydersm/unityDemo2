﻿using UnityEngine;
using System.Collections;

public class ExampleScript_C : MonoBehaviour 
{
	public GameObject[] enemies;

	// Use this for initialization
	void Start () 
	{
		enemies = GameObject.FindGameObjectsWithTag("Enemy");

		for(int i = 0; i < enemies.Length; i++)
		{
			print ("Enemy Number: " + i + "is named " + enemies[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}