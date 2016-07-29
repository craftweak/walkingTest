﻿using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	public GameObject target = null;
	public bool orbitY = false;

	private Vector3 positionOffset = Vector3.zero;

	private void Start()
	{
		positionOffset = transform.position -  target.transform.position;
	}

	

	private void Update () {
	
		if (target != null)
		{
			transform.LookAt (target.transform);

			if (orbitY)
				transform.RotateAround (target.transform.position, Vector3.up, Time.deltaTime * 15);

			transform.position = target.transform.position + positionOffset;
		}
	}
}