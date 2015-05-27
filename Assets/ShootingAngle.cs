using UnityEngine;
using System.Collections;

public class ShootingAngle : MonoBehaviour {

	private GameObject cannon;
	private bool clicked;
	private Vector2 thisPosition;
	private Vector2 referenceVector;
	private Quaternion cannonQuat; 
	private Animator anim;
	// Use this for initialization
	void Start () {
		cannon = GameObject.Find ("Bazooka");
		cannonQuat = Quaternion.identity;
		referenceVector = new Vector2 (1, 0);
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			clicked = true;
			Debug.Log ("Start Dragging");
			thisPosition = new Vector2 (transform.position.x, transform.position.y);
			Debug.Log (thisPosition.x);
			Debug.Log (thisPosition.y);
		} else if (Input.GetButtonUp ("Fire1")) {
			clicked = false;
		}

		if (clicked) {
			//Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//Vector2 mousePosition = new Vector2 (mouseWorldPoint.x, mouseWorldPoint.y);
			//float angle = Vector2.Angle (referenceVector, mousePosition - thisPosition);
			//Debug.Log (angle);
			//cannonQuat.z = angle;
			//transform.rotation = cannonQuat;
		}
	}
}
