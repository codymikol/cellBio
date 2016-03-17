using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


	private bool up = false;
	private bool right = false;
	private int random;
	public float movementSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		random = Random.Range (0, 2);
		if (random == 0) {
			right = true;
		} else {
			right = false;
		}
		random = Random.Range (0, 2);
		if (random == 0) {
			up = true;
		} else {
			up = false;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (right && up) 
		{
			directionUpRight();
		}
		else if(!right && up)
		{
			directionUpLeft();
		}
		else if (right && !up) 
		{
			directionDownRight();
		} 
		else if (!right && !up) 
		{
			directionDownLeft();
		}
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "UpperLowerBounds") {
			if (up) 
			{
				up = false;
			} 
			else if (!up) 
			{
				up = true;
			}
		}
		if (col.gameObject.tag == "RightLeftBounds") {
			if (right) 
			{
				right = false;
			} 
			else if (!right) 
			{
				right = true;
			}
		}
		/*if (col.gameObject.tag == "Cell") {
			bool tempRight = col.gameObject.GetComponent<Movement>().getRight();
			bool tempUp = col.gameObject.GetComponent<Movement>().getUp();
			if(tempRight && tempUp) {
				if(!right && up)
				{
					up = false;
					right = true;
				}
				if(right && up)
				{
					up = true;
					right = false;
				}
				if(right && !up)
				{
					up = true;
					right = true;
				}
				if(!right && !up)
				{
					up = false;
					right = true;
				}
			}
			if(!tempRight && tempUp) {
				if(!right && up)
				{
					up = false;
					right = true;
				}
				if(right && up)
				{
					up = false;
					right = true;
				}
				if(right && !up)
				{
					up = true;
					right = false;
				}
				if(!right && !up)
				{
					up = false;
					right = true;
				}
			}
			if(!tempRight && !tempUp) {
				if(!right && up)
				{
					up = false;
					right = true;
				}
				if(right && up)
				{
					up = true;
					right = false;
				}
				if(right && !up)
				{
					up = true;
					right = false;
				}
				if(!right && !up)
				{
					up = false;
					right = true;
				}
			}
			if(tempRight && !tempUp) {
				if(!right && up)
				{
					up = true;
					right = false;
				}
				if(right && up)
				{
					up = false;
					right = true;
				}
				if(right && !up)
				{
					up = true;
					right = false;
				}
				if(!right && !up)
				{
					up = false;
					right = true;
				}
			}

		}
		*/
	}

	void directionUpRight()
	{
		GetComponent<Rigidbody>().velocity = 1 * new Vector3 (movementSpeed, 0, movementSpeed);
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}
	void directionDownRight()
	{
		GetComponent<Rigidbody>().velocity = 1 * new Vector3 (movementSpeed, 0, -movementSpeed);
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}
	void directionUpLeft()
	{
		GetComponent<Rigidbody>().velocity = 1 * new Vector3 (-movementSpeed, 0,movementSpeed);
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}
	void directionDownLeft()
	{
		GetComponent<Rigidbody>().velocity = 1 * new Vector3 (-movementSpeed, 0, -movementSpeed);
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}

	public bool getUp() 
	{
		return up;
	}
	public bool getRight()
	{
		return right;
	}
}
