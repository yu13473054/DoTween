using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BtnClick : MonoBehaviour {
    public Transform dialogTrans;
    private bool isIn;
    Tweener tween;

	void Start () {
        /* 第二种方式
        tween = dialogTrans.DOLocalMoveX(0, 0.5f).SetAutoKill(false).Pause();
         * */
	}

    public void OnClick()
    {
        /*第一种方式，进入和移除屏幕
        if (isIn)
        {
            isIn = false;
            dialogTrans.DOLocalMoveX(1100, 0.5f);
        } 
        else
        {
            isIn = true;
            dialogTrans.DOLocalMoveX(0, 0.5f);
        }
        */

        /*第二种方式
        if (isIn)
        {
            isIn = false;
            //dialogTrans.DOPlayBackwards();
            tween.PlayBackwards();
        } 
        else
        {
            isIn = true;
            //dialogTrans.DOPlayForward();
            tween.PlayForward();
        }
         */
        //第三种方式
        if (isIn)
        {
            isIn = false;
            tween.PlayBackwards();
        } 
        else
        {
            isIn = true;
            if (tween == null)
            {
                tween = dialogTrans.DOLocalMoveX(0, 0.5f).SetAutoKill(false);
            }
            else
            {
                tween.PlayForward();
            }
        }
    }
}
