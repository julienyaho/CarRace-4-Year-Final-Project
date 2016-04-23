using UnityEngine;
using System.Collections;

public class CoinBehaviors : MonoBehaviour {

	public GameObject CoinBehavior;
//	lvlManager lvlPoint;
	//public int score = 0;
	void OnTriggerEnter(Collider collider)
	{
		switch (collider.gameObject.name) 
		{
		case "Car":
			Destroy (this.gameObject);
			break;
		}
	}

	void Start (){
//		lvlPoint = lvlManager.GetComponent<lvlManager> ();

	}

/*	void OnCollisionEnter3D(Collision3D other)
	{
		if (other.tag = "EUR")
		{
			
			Destroy (this.gameObject);
			print("collide with EUR");
			//score++;
		}*/
	}

