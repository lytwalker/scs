using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {

	// Properties
	public Transform hours, minutes, seconds;

	private const float
		hoursToDegrees = 360f / 12f,
		minutesToDegrees = 360f / 60f,
		secondsToDegrees = 360f / 60f;
	
	// Update is called once per frame
	private void Update () {
		DateTime time = DateTime.Now;

		// Set rotation negatively about the z-axis
		hours.localRotation = Quaternion.Euler (0f, 0f, time.Hour * -hoursToDegrees);
		minutes.localRotation = Quaternion.Euler (0f, 0f, time.Minute * -minutesToDegrees);
		seconds.localRotation = Quaternion.Euler (0f, 0f, time.Second * -secondsToDegrees);
	}
}
