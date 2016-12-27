using UnityEngine;
using System.Collections;

public class Done_Asteroid_Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		Transform center = GameObject.Find ("Center").transform;
		transform.LookAt(center);
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}