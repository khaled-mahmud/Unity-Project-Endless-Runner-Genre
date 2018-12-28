using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	private Rigidbody2D rb;
	private bool isDead = false;
	private Animator animator;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead == false && Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.zero;
			rb.AddForce(new Vector2(0, 200));

			animator.SetTrigger("fly2");
		}
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		isDead = true;
		GameControls.instance.BirdDied();

		animator.SetTrigger("dead");
	}
}
