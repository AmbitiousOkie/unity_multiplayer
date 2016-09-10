using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace S3

{

	public class playerController : NetworkBehaviour {

		public GameObject bulletPrefab;
		public Transform bulletSpawn;

		// Use this for initialization
		void Start () {
			if (isLocalPlayer) {
					GetComponent<MeshRenderer> ().material.color = Color.blue;
				}

		
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
		
			// Fires a bullet when the spacebar is pressed
			if (Input.GetKeyDown (KeyCode.Space)) {
				Fire ();
			}
		
		}

		void Fire() {
			// Creates the bullet from the prefab
			GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

			// Adds velocity to the bullet
			bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6.0f;

			// Destroy the bullet after 2 seconds
			Destroy(bullet, 2);
		}

//		public override void onStartLocalPlayer(){
		//void onStartLocalPlayer(){
		//	GetComponent<MeshRenderer> ().material.color = Color.blue;
		//}
	}
}

