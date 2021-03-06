﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tower : MonoBehaviour {
	protected Transform enemy;
	protected List<Transform> enemiesInRange = new List<Transform>();

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == GlobalStatics.playerTag) {
			enemiesInRange.Add(col.gameObject.transform);
			enemy = enemiesInRange[0];
			//Debug.Log(enemiesInRange.Count);
		}
	}

	void OnTriggerExit2D (Collider2D col) {
		if (col.tag == GlobalStatics.playerTag) {
			if (enemiesInRange.Contains(col.gameObject.transform)) {
				enemiesInRange.Remove(col.gameObject.transform);
				if (col.gameObject.transform == enemy) {
					if (enemiesInRange.Count >= 1) {
						enemy = enemiesInRange[0];
					} else {
						//Debug.Log("testing");
						enemy = null;
						enemiesInRange.Remove(col.gameObject.transform);
					}
				}
			}
		}
	}

	protected void Shoot () {
		GameObject bullet = Instantiate(Resources.Load<GameObject>("Bullets/Bullets1"), transform.position, Quaternion.identity) as GameObject;
		Bullet1 bulletScript = bullet.GetComponent<Bullet1>();
		bulletScript.getTarget(enemiesInRange[0]);
		bullet.transform.rotation = transform.rotation;
	}

	protected void ShootS () {
		GameObject bullet = Instantiate(Resources.Load<GameObject>("Bullets/Bullets2"), transform.position, Quaternion.identity) as GameObject;
		Bullet2 bulletScript = bullet.GetComponent<Bullet2>();
		//bulletScript.getTarget(enemiesInRange[0]);
		bullet.transform.rotation = transform.rotation;
	}
}