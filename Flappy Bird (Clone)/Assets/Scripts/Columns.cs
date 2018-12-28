using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour {

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-1, 0);
		
	}
	
	// Update is called once per frame
	void Update () {

		if(GameControls.instance.endGame == true)
		{
			rb.velocity = Vector2.zero;
		}
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.GetComponent<Bird>() != null)
		{
			GameControls.instance.BirdScored();
		}
	}
}
