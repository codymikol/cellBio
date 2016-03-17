using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clicking : MonoBehaviour {
	Ray ray;
	public GameObject PannelA;
	public GameObject PannelB;
	private bool clickedMonitor = false;
	private bool clickedClipBoard = false;
	RaycastHit hit;
	private GameObject mainCam;
	private pauseMenu pauseMenuSript;
	public GameObject monitor;
	public Transform clockSlider;
	public Transform close;
	private bool clickedClosed = false;
	void Awake(){
		//Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
	}

	void Start () {
		// Initialise ray
		//Cursor.lockState = CursorLockMode.Locked;
		mainCam = GameObject.Find ("MainCamera");
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		pauseMenuSript = mainCam.GetComponent<pauseMenu> ();
		close.GetComponent<Button> ().transform.localScale = new Vector3 (0, 0, 0);


	}
	
	void Update () {
		pauseMenuSript = mainCam.GetComponent<pauseMenu> ();
		if (pauseMenuSript.pauseEnabled == true) {

		} else {
			clicking();
		}
	}
	
	void clicking() { //ALL CLICKING OBJECTS
		// Use Input.GetKeyDown() for single clicks
		if(Input.GetKeyDown(KeyCode.Mouse0)) 
		{
			// Reset ray with new mouse position
			ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if(Physics.Raycast(ray, out hit)) {
				if(hit.collider.name == "Test_Tube_A") {
					Debug.Log("Test_Tube_A");
					PannelA.SetActive(true);
					PannelB.SetActive(false);
				}
				else if(hit.collider.name == "Test_Tube_B"){
					Debug.Log("Test_Tube_B");
					PannelA.SetActive(false);
					PannelB.SetActive(true);
				}
				else if(hit.collider.name == "Monitor")
				{
					Debug.Log("Monitor");
					if(!clickedMonitor)
					{
						moveToMonitor();
					}
					else
					{
						moveFromMonitor();
					}

				}
				else if(hit.collider.name == "Clipboard")
				{
					moveToClipBoard();
				}

				//Debug.Log();
			}
		}
		if (clickedClosed) {
			moveFromClipBoard();
			clickedClosed = false;
		}
		// Draw a red line from camera to selected object in Scene window
		//Debug.DrawLine(ray.origin, hit.point, Color.red); 
	}
	void moveToMonitor() //Might Change to Zoom in
	{
//		transform.position = monitor.transform.position;
//		transform.rotation = monitor.transform.rotation * Quaternion.Euler (-1f, -1f, -1f);
//		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 5f);


		transform.position = new Vector3 (12.13f, 6.95f, -2.52f);

		transform.rotation = Quaternion.Euler (1.6776f, 32.080f, .353f);
		clickedMonitor = true;
		clockSlider.GetComponent<Slider> ().enabled = false;
		close.GetComponent<Button> ().transform.localScale = new Vector3 (1f, 1f, 1f);
	}
	void moveFromMonitor() //Might Change to Zoom in
	{
		transform.position = new Vector3 (0f, 10.82f, -22.97f);
		
		transform.rotation = Quaternion.Euler (7.96f, 0, 0);
		clickedMonitor = false;
		clockSlider.GetComponent<Slider> ().enabled = true;
		close.GetComponent<Button> ().transform.localScale = new Vector3 (0, 0, 0);
	}
	void moveToClipBoard()
	{
		transform.position = new Vector3 (14.24f, 6.72f, -4.23f);
		
		transform.rotation = Quaternion.Euler (90f, 0, 0);
		clickedClipBoard = true;
		clockSlider.GetComponent<Slider> ().enabled = false;
		close.GetComponent<Button> ().transform.localScale = new Vector3 (1f, 1f, 1f);
	}
	void moveFromClipBoard()
	{
		transform.position = new Vector3 (0f, 10.82f, -22.97f);
		
		transform.rotation = Quaternion.Euler (7.96f, 0, 0);
		clickedClipBoard = false;
		clockSlider.GetComponent<Slider> ().enabled = true;
		close.GetComponent<Button> ().transform.localScale = new Vector3 (0, 0, 0);
	}
	public void clickedTheButton()
	{
		if (clickedClosed) {
			clickedClosed = false;
		} else {
			clickedClosed = true;
		}
	}
}
