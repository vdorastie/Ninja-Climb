using UnityEngine;
using System.Collections;

public class LavaRise : MonoBehaviour {

	public float speed=0.02f;
	public float error=3f;
	private float limit;
	private bool start=false;
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space)==true) start=true;
		if(start==true){
		limit=GameObject.Find("Player").transform.position.y-error;
		Vector3 pos = transform.position;
		pos.y+=speed;
		if(pos.y<limit) pos.y=limit;
		transform.position=pos;
		}
	}
}
