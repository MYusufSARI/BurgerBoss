using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public enum Mode
    {
        LookAt,
        LookAtInverted,
    }

    [SerializeField]
    private Mode mode;

    private void LateUpdate()
    {
        transform.LookAt(Camera.main.transform);
    }
}
