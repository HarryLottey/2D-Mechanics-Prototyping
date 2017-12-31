using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will change the cursor whenever nescessary to show clarity in gameplay.
public class SetCursor : MonoBehaviour
{

    Texture2D defaultCursor;
    Vector2 hotspot = Vector2.zero;

    // Use this for initialization
    void Start()
    {
        defaultCursor = Resources.Load("Icons/CursorPlaceholder") as Texture2D;
        Cursor.SetCursor(defaultCursor, hotspot, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
