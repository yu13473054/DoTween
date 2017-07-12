using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class To : MonoBehaviour {
    public Vector3 pos;
    public Vector3 end;

	void Start () {
        DOTween.To(() => pos, x => pos = x, end, 2);
	}
	
	void Update () {
        transform.position = pos;
	}
}
