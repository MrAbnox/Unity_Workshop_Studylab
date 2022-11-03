using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
	public Vector3 moveDirection { get; private set; }
	private Rigidbody rb;

	public void Move(InputAction.CallbackContext value)
	{
		Vector2 tempVector = value.ReadValue<Vector2>();
		moveDirection = new Vector3(tempVector.x, 0, tempVector.y);
	}

	//private void Move()
	//{
	//	rb.AddForce(velocity);
	//}

	//private void SetVelocity()
	//{
	//	velocity = inputController.moveDirection * speed;
	//}
}
