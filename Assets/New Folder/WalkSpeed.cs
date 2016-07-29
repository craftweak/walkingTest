using UnityEngine;
using System.Collections;
	




public class WalkSpeed : MonoBehaviour {



	Animator animator;
	public float sp;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		sp = 1.0f;

	}
	
	// Update is called once per frame
	void Update () {
		if (sp < 0)
			sp = 0;
		if (sp > 1)
			sp = 1;
		animator.SetFloat ("Walk", sp);
	}
}
