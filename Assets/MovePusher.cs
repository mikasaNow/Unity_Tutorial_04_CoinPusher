using UnityEngine;
using System.Collections;

public class MovePusher : MonoBehaviour {

	// default position
	private Vector3 origin;

	// Use this for initialization
	void Start () {

		Debug.Log ("Let's CoinPusher !!");

		// Pusher初期位置取得
		origin = GetComponent<Rigidbody> ().position;
	}
	
	// Update is called once per frame
	float speed = 0.02f;
	void Update () {
		//sin使う場合
		//Vector3 offset = new Vector3 (0, 0, Mathf.Sin (Time.time));
		//GetComponent<Rigidbody> ().MovePosition (origin + offset);

		Vector3 pos = GetComponent<Rigidbody> ().position;
		Debug.Log (pos.z);
		if (pos.z >= origin.z + 1.0f) {
			speed = -0.02f;
		} else if (pos.z <= origin.z - 1.5f) {
			speed = 0.02f;
		}
		GetComponent<Rigidbody> ().MovePosition (new Vector3(pos.x, pos.y, pos.z + speed));



	}
}
