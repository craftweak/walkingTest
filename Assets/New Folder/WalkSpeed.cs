using UnityEngine;
using System.Collections;
	




public class WalkSpeed : MonoBehaviour {



	Animator animator;
	public float speed;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		speed = 0.5f;

	}
	
	// Update is called once per frame
	void Update () {
		if (speed < 0)
			speed = 0;
		if (speed > 1)
			speed = 1;
		animator.SetFloat ("Walk", speed);
	}
}
