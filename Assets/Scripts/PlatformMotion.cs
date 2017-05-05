using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMotion : MonoBehaviour {

	//public float moveSpeed = 0.1f;
	public float moveMagnitude = 1.0f;
	// Update is called once per frame
	void Update () {
		
		gameObject.transform.Translate(Vector3.up*Mathf.Cos(Time.timeSinceLevelLoad)*moveMagnitude);

	}
}
