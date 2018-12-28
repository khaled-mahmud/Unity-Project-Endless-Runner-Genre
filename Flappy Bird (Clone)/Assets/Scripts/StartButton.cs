using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	private void OnMouseDown()
	{
		SceneManager.LoadScene("Main");
	}
}
