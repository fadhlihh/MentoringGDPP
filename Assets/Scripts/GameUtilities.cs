using UnityEngine;

public static class GameUtilities
{
    public static void SetCursorEnabled(bool value)
    {
        Cursor.visible = value;
        if (value == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
