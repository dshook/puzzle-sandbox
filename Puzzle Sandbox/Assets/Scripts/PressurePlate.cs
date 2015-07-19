using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class PressurePlate : MonoBehaviour {
	public GameObject target;

	Renderer rend;
	IOpenable targetTrigger;

	void Awake(){
		rend = GetComponent<Renderer>();
		targetTrigger = target.GetComponent<IOpenable>();
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

		if(targetTrigger != null){
			targetTrigger.Open();
		}
	}
		
		
	void OnTriggerExit (Collider other)
	{
		var color = rend.material.color;
		color.r -= 40;
		rend.material.color = color;

		if(targetTrigger != null){
			targetTrigger.Close();
		}
	}
}
