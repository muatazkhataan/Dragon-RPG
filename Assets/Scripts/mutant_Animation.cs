using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutant_Animation : MonoBehaviour {

	public Animation anim;

	IEnumerator Start() {
		anim = GetComponent<Animation> ();
		anim.Play (anim.clip.name);
		yield return new WaitForSeconds (anim.clip.length);
	}

}
