using UnityEngine;
using System.Collections;

public class Jigglyboby : MonoBehaviour {

	void Awake()
	{
		print(this.GetType() + " Awakens " + gameObject.name);
	}

	void Start()
	{
		print(this.GetType() + "STAETS " + gameObject.name);
	}
}
