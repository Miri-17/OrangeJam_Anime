using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachLight : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
