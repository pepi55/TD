﻿using UnityEngine;
using System.Collections;
//using UnityEditor;

//[ExecuteInEditMode()]
public class Snapper : MonoBehaviour {
	/*
	public float xStep;
	public float yStep;
	public float zStep;
	
	void Update () 
	{
		if(!gameObject.activeInHierarchy) return;
		
		if(Application.isPlaying) Destroy(this);
		
		if((Selection.activeTransform != null) && (Selection.activeTransform != transform) && (transform.IsChildOf(Selection.activeTransform)))
		{
			return;
		}
		
		Vector3 pos = transform.position;
		int gridSteps = Mathf.RoundToInt(pos.x / xStep);
		pos.x = ((float)gridSteps) * xStep;
		
		gridSteps = Mathf.RoundToInt(pos.y / yStep);
		pos.y = ((float)gridSteps) * yStep;
		
		gridSteps = Mathf.RoundToInt(pos.z / zStep);
		pos.z = ((float)gridSteps) * zStep;
		
		transform.position = pos;
	}*/
}