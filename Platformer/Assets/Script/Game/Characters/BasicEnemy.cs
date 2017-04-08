using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MovingObject {

	public float jumpForce = 0.15f;
	public float speed = 0.025f;
	public float speedDamping = 0.1f;
	public string toAttack = "Player";
	
	public override void FixedUpdateMovement() {
		GameObject attackObj = GameObject.FindGameObjectWithTag(toAttack);

		// Horizontal tracking(Walking)
		float target = ((attackObj.transform.position.x > transform.position.x) ? 1 : -1) * speed;
		velocity.x = Mathf.SmoothDamp(velocity.x, target, ref refDef, speedDamping);

		//Vertical tracking(Jumping)
		if(attackObj.transform.position.y > (transform.position.y + 0.5f) && base.collBottom) velocity.y = jumpForce;

		base.FixedUpdateMovement();
	}
}
