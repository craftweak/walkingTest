using UnityEngine;
using System.Collections;





public class WalkSpeed : MonoBehaviour {



	Animator animator;

//	[SerializeField]
	public float sp  
	{
		get { return sp; }
		set { sp = value; }
	}

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		sp = 0.5f;

	}

	// Update is called once per frame
	void Update () {

		animator.SetFloat ("Walk", sp);
	}
}
