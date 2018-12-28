using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	private float spawnYPosition;

	// Use this for initialization
	void Start () {
		SpawnColumn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnColumn()
	{
		spawnYPosition = Random.Range(-1f, 2.7f);
		Instantiate(prefab, new Vector2(4, spawnYPosition), Quaternion.identity);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.GetComponent<Columns>() != null)
		{
			SpawnColumn();
		}
	}

}
