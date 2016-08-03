using UnityEngine;
using System.Collections;

public class Controllo : MonoBehaviour
{
	// Velocità
	public float speed = 1.0F;

	// Rotazione
	public float rotazione = 3.0F;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		CharacterController controller = GetComponent<CharacterController>();

		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotazione, 0);

		transform.Translate (Input.GetAxis ("Vertical") * speed, 0, 0);

		var forward = transform.TransformDirection (Vector3.forward);
		var curSpeed = speed * Input.GetAxis ("Vertical");

		controller.SimpleMove (forward * curSpeed);
	}
}
