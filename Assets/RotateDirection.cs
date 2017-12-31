using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDirection : MonoBehaviour
{
   // Rotates invisible GameObject along the cursor position so we can use its Z axis values
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
