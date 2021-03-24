using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Texture2D cursorArrow;
    public Texture2D cursorButton;
    public Texture2D cursorBattle;


    public void Start()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseEnter()
    {
        Cursor.SetCursor(cursorButton, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseEnterBattle()
    {
        Cursor.SetCursor(cursorBattle, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}
