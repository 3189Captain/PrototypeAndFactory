using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
	public void LoadPrototype()
	{
		SceneManager.LoadScene("Prototype");
	}
	public void LoadFactory()
	{
		SceneManager.LoadScene("Factory");
	}
}
