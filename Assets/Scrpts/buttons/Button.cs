﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	//gameObjects
	public GameObject Trigger;
	public GameObject Controling;
	public GameObject particles;

	//setTos
	public Vector2 setForceTo = new Vector2();
	//orginal vars
	private Vector2 orginalForce;
	private float originalLifetime;

	//sprites
	private Sprite inactive;
	public Sprite active;
	private SpriteRenderer spriteRenderer;

	void Start(){
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		inactive=spriteRenderer.sprite;
		originalLifetime=particles.particleSystem.startLifetime;

		AddForce conChange = Controling.GetComponent<AddForce>();
		orginalForce=conChange.force;
	}

	void OnTriggerEnter2D (Collider2D col) {
		if(col.tag == GlobalStatics.playerTag && Trigger == col.gameObject){
			spriteRenderer.sprite=active;

			AddForce conChange = Controling.GetComponent<AddForce>();
			conChange.force=setForceTo;

			Animator ani = Controling.GetComponent<Animator>();
			ani.enabled=false;

			particles.particleSystem.startLifetime=0;

		}
	}
	
	void OnTriggerExit2D (Collider2D col) {
		if(col.tag == GlobalStatics.playerTag && Trigger == col.gameObject){
			spriteRenderer.sprite=inactive;
			AddForce conChange = Controling.GetComponent<AddForce>();
			conChange.force=orginalForce;
			Animator ani = Controling.GetComponent<Animator>();
			ani.enabled=true;

			particles.particleSystem.startLifetime=originalLifetime;
		}
	}
}
