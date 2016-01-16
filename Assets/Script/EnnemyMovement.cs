﻿using UnityEngine;
using System.Collections;

public class EnnemyMovement : MonoBehaviour {

	Transform player;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.
	
	
	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}
	
	
	void Update ()
	{

			nav.SetDestination (player.position);
		} 
}
