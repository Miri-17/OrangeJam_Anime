using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallNet : MonoBehaviour
{
    [SerializeField]
    private float move_z;

    private void Update()
    {
        if (transform.position.y < 0.83)
            return;
        
        transform.Translate(0, 0, move_z);
    }
}
