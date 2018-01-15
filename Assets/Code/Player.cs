using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour 
{
	public Button turnbutton;
	public Button movebutton;
	public float startingpositionx = 0.75f;
	public float startingpositiony = 0.75f;
	public bool turn = false;
	public int speed = 5;
	public int speedleft;
	private int tokens = 2;
	private int tokensleft;

	void Move()
	{
	}

	void Action()
	{
	}

	void turnFunction()
	{
		turn = !turn;
	}

	void Start () 
	{
		transform.position = new Vector3 (startingpositionx, startingpositiony, 0);
		speedleft = speed;
		tokensleft = tokens;
		turnbutton.onClick.AddListener (turnFunction);
		movebutton.onClick.AddListener (Move);
	}

	void FixedUpdate () 
	{
		
		if (!turn) 
		{
			speedleft = speed;
			tokensleft = tokens;
		}
		if (turn) 
		{
		}
	}

}
