using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	public float velocity = 1f;

	public Transform sightStart;
	public Transform sightEnd;

	public bool colliding;

	// Use this for initialization
	void Start () {

	}

	//Update is called once per frame
	void Update () {

		rigidbody2D.velocity = new Vector2 (velocity, rigidbody2D.velocity.y);

		colliding = Physics2D.Linecast (sightStart.position, sightEnd.position);

		if (colliding) {

			transform.localScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);
			velocity *= -1;
		}
	}
}
