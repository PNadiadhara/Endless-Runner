using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour
{

    public Animator camAnimate;

    public void CamShake()
    {
        camAnimate.SetTrigger("shake");
    }
}
