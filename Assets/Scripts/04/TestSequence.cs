using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TestSequence : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	   Sequence sequence = DOTween.Sequence();
       sequence.Append(transform.DOMoveX(5, 2)).Append(transform.DOMoveY(3, 1)).Append(transform.DOMoveZ(10, 2));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
