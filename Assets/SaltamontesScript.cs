using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltamontesScript : MonoBehaviour {

	// Use this for initialization
	public Vector3 mousePosition, targetPosition;
	public GameObject cuboPrefab;
	private float distance = 10f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			mousePosition = Input.mousePosition;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        
			targetPosition=Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x,mousePosition.y,distance));
			cuboPrefab.transform.position = targetPosition;
			Debug.Log ("mouse position: " + "x: "+Input.mousePosition.x +"y: "+Input.mousePosition.y);
			Debug.Log ("entro a fire1");
				Instantiate (cuboPrefab, transform.position, transform.rotation);
		}
	}
}
