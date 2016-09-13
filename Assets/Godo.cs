using UnityEngine;
using System.Collections;

public class Godo : MonoBehaviour {

	Thingymabob tmb;
	Jigglyboby jig;
	Boaty_McBoatface boat; 

	void Awake()
	{
		tmb = GetComponent<Thingymabob>();
		print(tmb.GetType() + " found");


		boat = gameObject.AddComponent<Boaty_McBoatface>();
		print(boat.GetType() + " found");


		jig = gameObject.AddComponent<Jigglyboby>();  //adding a component should  make it's awake occur right away
		print(jig.GetType() + " found."); 

	}

	void Start () {
		
	}
	
	void Update () {
	
	}
}
