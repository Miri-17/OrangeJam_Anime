using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFeather : MonoBehaviour
{
    [SerializeField]
    private float move_x;
    [SerializeField]
    private float rotate_z;

    private void Update()
    {
        transform.Translate(move_x, 0, 0, Space.World);
        transform.Rotate(0, 0, rotate_z, Space.World);
    }
}
