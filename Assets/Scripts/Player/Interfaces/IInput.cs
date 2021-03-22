using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInput
{
    int GetHorizontalInput(int lane);
    void GetJumpInput();
    void GetSlideInput();

}
