using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightOne : MonoBehaviour
{

	private GameObject mainCube;

	void Start()
	{
		mainCube = GameObject.Find("Main Cube");
	}

	void OnMouseDown()
	{
		if (GetComponent<Renderer>().material.color == mainCube.GetComponent<Renderer>().material.color)
			mainCube.GetComponent<GameCntrl>().next = true;
		else
			mainCube.GetComponent<GameCntrl>().lose = true;
	}
}