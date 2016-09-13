using UnityEngine;
using System.Collections;

public class Thingymabob : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{
		print(this.GetType() + " Awakens " + gameObject.name);
	}

	void Start()
	{
		print(this.GetType() + "STAETS " + gameObject.name);
	}
}
