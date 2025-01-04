using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Vector3 initialDistance;
    [SerializeField]
    private GameObject player;
    private void Reset()
    {
        LoadComponent();
    }

    private void LateUpdate()
    {
        TrackingPlayer();
    }

    private void TrackingPlayer()
    {
        this.transform.position = player.transform.position + initialDistance;
    }

    private void LoadComponent()
    {
        player = GameObject.Find("Player");
        initialDistance = this.transform.position - player.transform.position;
    }
}
