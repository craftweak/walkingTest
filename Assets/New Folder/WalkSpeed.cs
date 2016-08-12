using UnityEngine;
using System.Collections;

public class WalkSpeed : MonoBehaviour {

	Animator animator;
	[SerializeField]
	public float _sp = 0.5f;
	
		public float sp{
		get { return _sp; }
		set { _sp = value; }
	}

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		_sp = 0.5f;

	}

	// Update is called once per frame
	void Update () {

		animator.SetFloat ("Walk", _sp);
	}
}
