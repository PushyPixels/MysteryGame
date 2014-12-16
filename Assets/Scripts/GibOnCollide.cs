using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour
{
	public GameObject[] gibs;
	[Tooltip("Object to destroy when colliding (Optional)")]
	public GameObject destroyTarget;
	public bool onCollide = true;
	public bool onTrigger = true;

	private GameObject target;

	// Use this for initialization
	void Start ()
	{
		if(destroyTarget != null)
		{
			target = destroyTarget;
		}
		else
		{
			target = gameObject;
		}
	}

	void OnCollisionEnter()
	{
		if(onCollide)
		{
			Gib();
		}
	}

	void OnTriggerEnter()
	{
		if(onTrigger)
		{
			Gib();
		}
	}
	

	void Gib ()
	{
		foreach(GameObject gib in gibs)
		{
			Instantiate (gib,transform.position,transform.rotation);
		}
		Destroy(target);
	}
}
