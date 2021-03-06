﻿using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour {

	GameObject prefab;
	void Start () {

		prefab = Resources.Load("projectile") as GameObject;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject projectile = Instantiate(prefab) as GameObject;
			projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
			Rigidbody rb = projectile.GetComponent<Rigidbody>();
			rb.velocity = Camera.main.transform.forward * 20;
		}
	}
}