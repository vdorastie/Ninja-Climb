using UnityEngine;
using System.Collections;

public class Infinitesteps : MonoBehaviour {

	int numBGPannels=9;
	float change=1f;
	void OnTriggerEnter2D(Collider2D collider){
	
	Debug.Log ("Triggered: "+collider.name);
	float widthOFBGObject=((BoxCollider2D)collider).size.y;
	
	Vector3 pos = collider.transform.position;
	pos.y +=change*widthOFBGObject*numBGPannels;
	pos.x=Random.Range(-4f, 3f);
	collider.transform.position=pos;
	
	}
}
