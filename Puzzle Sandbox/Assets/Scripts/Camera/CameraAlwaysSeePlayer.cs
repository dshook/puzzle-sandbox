using UnityEngine;
using System.Collections;

public class CameraAlwaysSeePlayer : MonoBehaviour {
	public Transform target;

	RaycastHit objectHit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position, transform.forward, out objectHit)){
			if(objectHit.transform == target) return;

			Renderer rend = objectHit.transform.GetComponent<Renderer>();
			MeshCollider meshCollider = objectHit.collider as MeshCollider;
			if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
				return;

			var c = rend.material.color;
			c.a = 0.5f;
			rend.sharedMaterial.color = c;

		}

	}
}
