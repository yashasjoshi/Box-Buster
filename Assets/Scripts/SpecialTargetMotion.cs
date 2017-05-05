using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTargetMotion : MonoBehaviour {

	public float motionSpeed = 1.0f;

	// Update is called once per frame
	void Update () {
	
		gameObject.transform.Translate (Vector3.down*Mathf.Cos(1)*motionSpeed);

	}
}
