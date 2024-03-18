using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachPlane : MonoBehaviour
{
    [SerializeField]
    private float move_x;

    private void Update()
    {
        transform.Translate(move_x, 0, 0, Space.World);
    }
}
