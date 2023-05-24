using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseBtn : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("GangnamStyle", false);
        anim.SetBool("Sitting", false);
    }

    public void ChangePoseAnim_0()
    {
        anim = GameObject.Find("UnityIntroductionTestModel").GetComponent<Animator>();
    }

    public void ChangePoseAnim_1()
    {
        anim = GameObject.Find("UntITM1").GetComponent<Animator>();
    }

    public void ChangePose1()
    {
        anim.SetBool("GangnamStyle", true);
        anim.SetBool("Sitting", false);
    }

    public void ChangePose2()
    {
        anim.SetBool("GangnamStyle", false);
        anim.SetBool("Sitting", true);
    }
}
