using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicController : MonoBehaviour {

	public float moveSpeed = 8f;
	public float gravity = 9.81f;
	
	private CharacterController myController;

	void start () {
	
		myController = gameObject.GetComponent<CharacterController> ();

	}
		
	// Update is called once per frame
	void Update () {

		Vector3 movementZ = Input.GetAxis ("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
		Vector3 movementX = Input.GetAxis ("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

		Vector3 movement = transform.TransformDirection(movementX + movementZ);

		movement.y -= gravity * Time.deltaTime;

		Debug.Log ("Movement Vector = " + movement);
		myController.Move (movement);

		/*
		Debug.Log("Horizontal Input = " + Input.GetAxis("Horizontal"));
		Debug.Log("Horizontal Input = " + Input.GetAxis("Vertical"));
		gameObject.transform.Translate (Vector3.left * Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime);
*/
		gameObject.transform.Rotate(Vector3.up * Input.GetAxis ("Horizontal") * moveSpeed* 10 * Time.deltaTime);

	}
}
