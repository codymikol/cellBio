using UnityEngine;
using System.Collections;

public class Highlight : MonoBehaviour {
	public Material highlightedColor;
	public Material unhighlightedColor;
	public Renderer rend;
	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();

	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnMouseEnter()
	{
		rend.material = highlightedColor;
	}
	void OnMouseExit()
	{
		rend.material = unhighlightedColor;
	}
}
