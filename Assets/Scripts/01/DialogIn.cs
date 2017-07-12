using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DialogIn : MonoBehaviour {
    
	void Start () {
        DOTween.To(() => transform.localPosition, x => transform.localPosition = x, new Vector3(), 1);
	}
	
}
