using UnityEngine;
using System.Collections;

public class carControls : MonoBehaviour {
	
	public float carSpeed;

	public float maxPos = 2.2f;
	Vector2 position;



	// Use this for initialization
	void Start () {
		
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -2.0f, 2.2f);

		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "Enemy Car") {
			Destroy (gameObject);
		}

	}

}
