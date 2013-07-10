using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
	
	//public GameObject mySun;
	
	public float orbitRadius = 15f;
	public float orbitSpeed = 100f;
	public float sphereSize = 1.0f;
	
	// Use this for initialization
	void Start () {
		orbitSpeed = Random.Range(3f,50f);
		orbitRadius = Random.Range (6f,20f);
		sphereSize = Random.Range(.1f, 2.0f);
		
		this.gameObject.transform.localScale = new Vector3(sphereSize,sphereSize,sphereSize);
		
		this.transform.position = new Vector3(orbitRadius,0,0);
		this.transform.RotateAround (Vector3.zero, Vector3.up, Random.Range(0,360f));
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("orbiting");
		// orbit around the sun
		//transform.RotateAround(mySun.transform.position, Vector3.up, orbitSpeed*Time.deltaTime);
		this.transform.RotateAround(Vector3.zero, Vector3.up, orbitSpeed*Time.deltaTime);

	}
}
