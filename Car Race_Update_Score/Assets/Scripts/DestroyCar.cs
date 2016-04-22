using UnityEngine;
using System.Collections;

public class DestroyCar : MonoBehaviour 
{
	void Start ()
	{
		Destroy (this.gameObject);
	}
	/*public GameObject RoadBlocker;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "RoadBlocker") 
		{
			Destroy (this.gameObject);
		}
	}*/

	/*void OntriggerStay(Collider col)
	{
		Debug.Log ("Stayed");
	}

	void OntriggerExit(Collider col)
	{
		Debug.Log ("Exit");
	}*/


	/*public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveRight;
	public KeyCode moveLeft;


	void Update ()
	{
		if (Input.GetKeyDown (moveUp))
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 3, 0);

		if (Input.GetKeyDown (moveDown))
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -3, 0);

		if (Input.GetKeyDown (moveRight))
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (-3, 0, 0);

		if (Input.GetKeyDown (moveLeft))
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (3, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}
}*/
	void OnCollisionEnter (Collision col)
	{
	if (col.collider.gameObject.name == "RoadBlocker") 
		{
		Destroy (col.collider.gameObject);
		
		}
	}
}

