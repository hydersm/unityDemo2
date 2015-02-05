﻿using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour 
{
	/*
	Assignment Operators:
	= 
	+= x = x + y (x+=y)
	-= x = x - y (x-=y)
	*=
	/=
	%=

	Arithmetic Operators:
	+ Addition
	- Subtraction
	* Multiplication
	/ Division
	% Modulus
	++ (+1)
	-- (-1)

	Comparison Operators:
	== Is equal to
	!= Not equal to
	> 
	<
	>=
	<=

	Logical Operators:
	&& And
	|| Or 
	! Not 
	
	*/

	public float speed = 0.0f;
	public float distance = 0.0f;
	public float time = 0.0f;

	public float maxSpeedLimit = 70.0f;
	public float minSpeedLimit = 40.0f;

	// Use this for initialization
	void Start () 
	{
		speed = distance / time;
		if(speed > maxSpeedLimit)
		{
			print ("You are exceeding the speed limit!");
		}
		else if(speed < minSpeedLimit)
		{
			print ("You are not going fast enough!");
		}
		else if(speed == maxSpeedLimit || speed == minSpeedLimit)
		{
			print ("You are close to breaking the law!");
		}
		else
		{
			print ("You are within the speed limit!");
		}
		print ("You are traveling at " + speed + " MPH.");
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
