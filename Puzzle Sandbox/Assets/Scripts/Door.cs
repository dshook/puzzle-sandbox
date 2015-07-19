using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Door : MonoBehaviour, IOpenable {
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Open(){
		anim.SetBool ("Open", true);
	}

	public void Close(){
		anim.SetBool ("Open", false);
	}
}
