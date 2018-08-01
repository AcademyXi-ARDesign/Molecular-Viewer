using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	public Transform Target;
	[Range(0f, 1f)] public float LerpSpeed = 0.2f;

	// Use this for initialization

	void Start () {

	}

	void Update () {
		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Target.position - transform.position, Vector3.up), LerpSpeed);
	}
}