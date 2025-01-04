using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : BaseStateManager
{
    [Header("Cache Component")]
    [SerializeField]
    private VariableJoystick variableJoystick;
    [SerializeField]
    private CharacterController characterController;

    [Header("Player Variable")]
    [SerializeField]
    public float moveSpeed = 5f;

    [SerializeField]
    public float rotationSpeed = 10f;

    private void Reset()
    {
        LoadComponent();
    }

    private void LoadComponent()
    {
        variableJoystick = GameObject.Find("Variable Joystick").GetComponent<VariableJoystick>();
        characterController = this.transform.parent.GetComponent<CharacterController>();
    }

    public override void DisableAllAnimations()
    {
    }

    public override void InitialState()
    {
    }

    public override void SwicthState(BaseState baseState)
    {
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveDirection = new Vector3(variableJoystick.Direction.x, 0f, variableJoystick.Direction.y);

        //Check value of square Vector3 of joystick
        //if (moveDirection.sqrMagnitude <= 0f && !stateManager.hasAttacked)
        //{
        //    stateManager.SwitchState(stateManager.idleState);
        //    return;
        //}

        characterController.SimpleMove(moveDirection * moveSpeed);

        //stateManager.animator.SetBool(AnimationStrings.isIdle, false);

        Vector3 targetDirection = Vector3.RotateTowards(characterController.transform.forward, moveDirection, rotationSpeed * Time.deltaTime, 0f);

        characterController.transform.rotation = Quaternion.LookRotation(targetDirection);
    }
}
