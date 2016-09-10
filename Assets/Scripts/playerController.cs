using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3

{

	public class playerController : NetworkBehaviour {

		// Use this for initialization
		void Start () {


		
		}
		
		// Update is called once per frame
		void Update () {

			if (!isLocalPlayer) {
				return;
				}

			float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
			float y = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;

			transform.Rotate (0, x, 0);
			transform.Translate (0, 0, y);
		
		}
	}
}
