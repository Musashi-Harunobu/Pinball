using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator leftFlipper;
    [SerializeField] private Animator rightFlipper;
    [SerializeField] private Animator plunger;

    void Update()
    {
        // Управление левым флиппером
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftFlipper.SetTrigger("Shot");
        }
        // Управление правым флиппером
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightFlipper.SetTrigger("Shot");
        }

        // Получаем информацию о текущем состоянии анимации
        AnimatorStateInfo stateInfo = plunger.GetCurrentAnimatorStateInfo(0);

        // Управление плунджером
        if (Input.GetKey(KeyCode.Space))
        {
            if (stateInfo.normalizedTime < 0)
            {
                plunger.SetFloat("Direction", 0);
            }
            else
            {
                plunger.SetFloat("Direction", -1);
            }
        }
        else
        {
            if (stateInfo.normalizedTime > 1)
            {
                plunger.SetFloat("Direction", 0);
            }
            else
            {
                plunger.SetFloat("Direction", 1);
            }
        }

    }
}
