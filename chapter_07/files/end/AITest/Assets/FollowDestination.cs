﻿using UnityEngine;
using System.Collections;

public class FollowDestination : MonoBehaviour
{
	private NavMeshAgent ThisAgent = null;
	public Transform Destination = null;

	// Use this for initialization
	void Awake () 
	{
		ThisAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		ThisAgent.SetDestination(Destination.position);
	}
}
