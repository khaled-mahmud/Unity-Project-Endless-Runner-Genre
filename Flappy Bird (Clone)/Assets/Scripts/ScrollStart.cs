using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollStart : MonoBehaviour
{

	private BoxCollider2D groundCollider;
	private float horizontalLength;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{

		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-1, 0);

		groundCollider = GetComponent<BoxCollider2D>();
		horizontalLength = groundCollider.size.x;

	}

	// Update is called once per frame
	void Update()
	{

		

		if (transform.position.x < -horizontalLength * 1.5f)
		{
			transform.position = new Vector2(horizontalLength * 1.5f, transform.position.y);
		}

	}
}
