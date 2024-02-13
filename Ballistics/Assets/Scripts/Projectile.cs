using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	void Start()
	{
		StartCoroutine(DeleteProjectile());
	}

	IEnumerator DeleteProjectile() 
	{
		yield return new WaitForSeconds(8);

		Destroy(gameObject);
		yield return null;
	}
}
