using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; 
    private Vector3 cameraPositon;

    void Start()
    {
        cameraPositon = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + cameraPositon;
    }
}
