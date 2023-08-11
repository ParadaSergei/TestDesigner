using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehaviour : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (countPoint.numberPoint == 1 || countPoint.numberPoint == 3)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRun", true);
        }
        else if (countPoint.numberPoint == 0 || countPoint.numberPoint == 2)
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isRun", false);
        }
    }
}
