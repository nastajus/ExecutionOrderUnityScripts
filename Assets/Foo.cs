using UnityEngine;
using System.Collections;

public class Foo : MonoBehaviour
{

	// Use this for initialization
	void Awake()
	{
		print(this.GetType() + " Awakens " + gameObject.name);
	}

	void Start()
	{
		print(this.GetType() + "STAETS " + gameObject.name);
	}

	// Update is called once per frame
	void Update()
	{

	}
}

