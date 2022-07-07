using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
   public Texture2D cursorTexture;

    public CursorMode cursorMode = CursorMode.Auto;

    public Vector2 hotSpot = Vector2.zero;


    // Start is called before the first frame update
    public void CursorHover()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

        Debug.Log("Hover");
    }

    // Update is called once per frame
    public void CursorExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}


