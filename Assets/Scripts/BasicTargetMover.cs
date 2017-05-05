using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {

	public enum motionDirections {Spin, Horizontal, Vertical};

	public motionDirections motionState = motionDirections.Horizontal;
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f; 

	// Update is called once per frame
	void Update () {

					//Rotate around the up axis of the game object
		if(motionState == motionDirections.Spin)
			gameObject.transform.Rotate (Vector3.up*spinSpeed * Time.deltaTime);

					//Move Vertically over time
		if(motionState == motionDirections.Vertical)
			gameObject.transform.Translate(Vector3.up*Mathf.Cos(Time.timeSinceLevelLoad)*motionMagnitude);

					//Move Horizontally over time
		if(motionState == motionDirections.Horizontal)
			gameObject.transform.Translate(Vector3.forward*Mathf.Cos(Time.timeSinceLevelLoad)*motionMagnitude);
	}
}