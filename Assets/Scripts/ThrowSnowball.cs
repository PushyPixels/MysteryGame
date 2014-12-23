using UnityEngine;
using System.Collections;

public class ThrowSnowball : MonoBehaviour
{
	private Animator throwingArm;
	public float force = 10.0f;
	public ForceMode forceMode = ForceMode.VelocityChange;
	public string throwButton = "Fire1";
	public string throwAnimationTriggerName = "ThrowSnowball";
	public Rigidbody snowballPrefab;
	public Transform throwPosition;
	public Transform throwAngle;

	void Start()
	{
		throwingArm = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if(Input.GetButtonDown(throwButton))
		{
			throwingArm.SetTrigger(throwAnimationTriggerName);
		}
	}

	void ThrowEvent()
	{
		Rigidbody instance = Instantiate(snowballPrefab,throwPosition.position,throwAngle.rotation) as Rigidbody;
		instance.AddForce(instance.transform.forward*force,forceMode);
	}
}
