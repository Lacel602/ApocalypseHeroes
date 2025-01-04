using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateManager: MonoBehaviour
{
    public abstract void DisableAllAnimations();

    public abstract void SwicthState(BaseState baseState);

    public abstract void InitialState();
}

