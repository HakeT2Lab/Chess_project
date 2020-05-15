using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
  	public void Doquit()
	{
		Debug.Log ("Has Quit Game");
		Application.Quit();
	}
}
