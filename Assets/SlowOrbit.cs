using UnityEngine;
using System.Collections;

public class SlowOrbit : MonoBehaviour {
	public float speed = .64f;
	public float bobRange = .5f;
	public float bobSpeed = .005f;
	private float tt = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (Vector3.zero, Vector3.up, speed*Time.deltaTime);
		this.transform.Translate(0,-bobRange * Mathf.Sin(tt)*Time.deltaTime,0);
		tt+=bobSpeed;
		this.transform.LookAt(Vector3.zero);
		this.transform.Translate (Vector3.forward * Mathf.Sin (tt*.22f)*Time.deltaTime);
	}
}
