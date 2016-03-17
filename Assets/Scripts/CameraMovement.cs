using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float speed = 10.0f;
	public int boundary = 1;
	public int width;
	public int height;
	
	void Start () {
		width = Screen.width;
		height = Screen.height;
		
	}
	
	void Update () {
		if (Input.mousePosition.x > width - boundary)
		{
			transform.position -= new Vector3 (Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, 
			                                   0.0f, 0.0f);
		}
		
		if (Input.mousePosition.x < 0 + boundary)
		{
			transform.position -= new Vector3 (Input.GetAxisRaw ("Mouse X") * Time.deltaTime * speed, 
			                                   0.0f, 0.0f);
		}
		
		if (Input.mousePosition.y > height - boundary)
		{
			transform.position -= new Vector3 (0.0f, 0.0f, 
			                                   Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed);		
		}
		
		if (Input.mousePosition.y < 0 + boundary)
		{
			transform.position -= new Vector3 (0.0f, 0.0f, 
			                                   Input.GetAxisRaw ("Mouse Y") * Time.deltaTime * speed);		
		}
		
	}
}
