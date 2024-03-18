using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChild : MonoBehaviour
{
    [SerializeField]
    private float move_z;

    private void Update()
    {
        if (transform.position.z > 19.31)
            return;
        
        transform.Translate(0, 0, move_z, Space.World);
    }
}
