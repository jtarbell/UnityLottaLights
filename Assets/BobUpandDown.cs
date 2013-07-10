using UnityEngine;
using System.Collections;

public class Oscillate : MonoBehaviour {
	
	public float range = 10f;
	public float speed = 1f;
	public float home = 0f;
	
	private float tt = 0.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		this.transform.Translate(0,speed * Time.deltaTime, 0);
		
		tt+= speed * Time.deltaTime;
//		this.transform.Translate(0, Mathf.Sin(tt)*range, 0);
		Vector3 pos = this.transform.position;
		this.transform.position = new Vector3(pos.x, Mathf.Sin (tt)*range + home, pos.z);
	}
}
