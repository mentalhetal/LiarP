using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float offsetX = 0.5f;
    public float offsetY = 0.5f;
    public float offsetZ = -4f;

    Vector3 cameraPosition = new Vector3();
    float followSpeed = 10;
}
