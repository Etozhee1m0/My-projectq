using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float leftLimit;
    [SerializeField] float rightLimit;

    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), transform.position.y, transform.position.z);
    }

}
