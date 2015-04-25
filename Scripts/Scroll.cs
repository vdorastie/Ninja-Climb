using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	


	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer> ();
		Material mat = mr.material;
		Vector2 offset = mat.mainTextureOffset;
		float pos = GameObject.Find("Player").transform.position.y;
		offset.y = pos/transform.localScale.y;
		mat.mainTextureOffset = offset;
	}
}
