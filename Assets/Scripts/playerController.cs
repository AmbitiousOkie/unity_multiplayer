using UnityEngine;
using System.Collections;

namespace S3

{

	public class playerController : MonoBehaviour {

		// Use this for initialization
		void Start () {


		
		}
		
		// Update is called once per frame
		void Update () {

			float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
			float y = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;

			transform.Rotate (0, x, 0);
			transform.Translate (0, 0, y);
		
		}
	}
}
