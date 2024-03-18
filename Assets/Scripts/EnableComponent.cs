using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponent : MonoBehaviour
{
    [Header("有効にするコンポーネント"), SerializeField]
    private MonoBehaviour targetComponent;
    [Header("待機する時間"), SerializeField]
    private float delayTime = 1.0f;

    private float elapsedTime = 0.0f;
    private bool isEnabled = false;

    private void Start()
    {
        targetComponent.enabled = false;
    }
    
    private void Update()
    {
        if (!isEnabled)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= delayTime)
            {
                targetComponent.enabled = true;
                isEnabled = true;
            }
        }
    }
}
