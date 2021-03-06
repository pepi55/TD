﻿using UnityEngine;
using System.Collections;

public class Tower1 : Tower {

	private float time = 0;
	private float fireRate = 1;

	private float xDiff;
	private float yDiff;
	
	private float radians;
	private float degrees;
	public float offsetRot = 0f;

	private Vector3 tempPos;
	private bool paused = false;

	void OnPauseGame ()
	{
		paused = true;
	}
	
	void OnResumeGame ()
	{
		paused = false;
	}

	void Update () {
		if(!paused) {
			if (enemy) {
				//transform.rotation = Quaternion.FromToRotation(Vector3.up - transform.position, enemy.transform.position - transform.position);
				xDiff = enemy.position.x - transform.position.x; 
				yDiff = enemy.position.y - transform.position.y;

				radians = Mathf.Atan2(yDiff, xDiff);
				degrees = ((radians * 180) / Mathf.PI)+offsetRot;

				transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, degrees);

				time += fireRate * Time.deltaTime;

				if (time >= 0.5) {
					Shoot();

					time = 0;
				}
			}
		}
	}
}