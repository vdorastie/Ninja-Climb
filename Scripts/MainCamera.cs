using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	Transform player;
	public float error=1.5f;
	float offsetx;
	void Start() {
		GameObject player_go = GameObject.Find("Player");
		player = player_go.transform;
		offsetx = transform.position.y-player.position.y;
	}
	
	void Update()
	{
		if(player!=null)
		{
			Vector3 pos = transform.position;
			pos.y=player.position.y+offsetx+error;
			transform.position=pos;
		}
	}
}
