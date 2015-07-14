using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {
	BoxCollider collide;
	Renderer rend;

	void Awake(){
		collide = GetComponent<BoxCollider>();
		rend = GetComponent<Renderer>();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

		   
	void OnTriggerEnter (Collider other)
	{
		var color = rend.material.color;
		color.r += 40;
		rend.material.color = color;
	}
		
		
	void OnTriggerExit (Collider other)
	{
		var color = rend.material.color;
		color.r -= 40;
		rend.material.color = color;
	}
}
