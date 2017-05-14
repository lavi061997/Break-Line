using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	public float speed = 5f;
	public float incSpeed = 10f;
	public float maxDist = 12f;
	public bool counter = true;

	public Rigidbody2D rb;


	void Start()
	{
		rb.velocity = new Vector2(0, speed);
		// Initially object is facing up (Y-axis)
		transform.localRotation = Quaternion.Euler(Vector3.up);
	}


	private void FixedUpdate()
	{
		
		if (Input.GetButtonDown("Jump"))
		{
			if (counter)
			{
				rb.velocity = new Vector2(incSpeed, speed);
				counter = !counter;

			}
			else
			{
				rb.velocity = new Vector2(-incSpeed, speed);
				counter = !counter;

			}
		}

		if (rb.position.x > 6)
		{
			Left();
		}

		if(rb.position.x< -6)
		{
			Right();
		}
	}
	public void Left()
	{

		rb.velocity = new Vector2(0, speed);
		// Initially object is facing up (Y-axis)
		transform.localRotation = Quaternion.Euler(Vector3.up);
		transform.position = new Vector2(5.9f, rb.position.y);
	}

	public void Right()
	{

		rb.velocity = new Vector2(0, speed);
		// Initially object is facing up (Y-axis)
		transform.localRotation = Quaternion.Euler(Vector3.up);
		transform.position = new Vector2(-5.9f, rb.position.y);

	}

}
