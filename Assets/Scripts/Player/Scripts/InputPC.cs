using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPC : MonoBehaviour,IInput
{
    public int GetHorizontalInput(int lane)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lane++;
            if (lane > 2)
            {
                lane = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lane--;
            if (lane < 0)
            {
                lane = 0;
            }
        }
        return lane;
    }

    public void GetJumpInput()
    {
        Debug.Log("Jump");
    }

    public void GetSlideInput()
    {
        Debug.Log("Slide");
    }
}
