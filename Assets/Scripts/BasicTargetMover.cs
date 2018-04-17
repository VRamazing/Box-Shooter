using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {
	public enum motionDirections { Spin, Horizontal, Vertical };

	//store the state
	public motionDirections motionState = motionDirections.Horizontal;

	//motion parameters
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;
	/*
	public bool doSpin = true;
	public bool doMotion = true;
   */

	// Update is called once per frame
	void Update () {
		/*
		if (doSpin) {
			//rotate around the up axis of the gameObject
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (doMotion) {
			//move up and down over time
			gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
		}*/

		switch (motionState) {
		case motionDirections.Spin:
			//rotate around the up axis of gameObject
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
			break;
		case motionDirections.Horizontal:
			//move left and right over time
			gameObject.transform.Translate (Vector3.right * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		case motionDirections.Vertical:
			//move up and down over time
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
			break;
		}
	}
}
