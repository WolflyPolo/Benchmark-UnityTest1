using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvispaScript : MonoBehaviour {

	// Use this for initialization
	//Script generador de cubos con física. 
	public GameObject cuboPrefab;
	private float posicionRandom;
	private float segReset = 0f;
	public float reset = 0;
	private int contador_cubos = 0;
	public Text cubos_text;
	public int fpsRate;
	public Text fpsText;

	void Start () {
		InvokeRepeating ("Spawnear", reset, reset);
	}
		
	// Update is called once per frame

	void Update () {
		fpsRate = (int)(1f / Time.unscaledDeltaTime);
		cubos_text.text = "C U B E S : " + contador_cubos;
		fpsText.text = "F P S : " + fpsRate;
	}
		
	void Spawnear() {
		posicionRandom = Random.Range (-24, 24);
		Instantiate (cuboPrefab, new Vector2(posicionRandom, 10f), cuboPrefab.transform.rotation);
		contador_cubos++;
	}


}
