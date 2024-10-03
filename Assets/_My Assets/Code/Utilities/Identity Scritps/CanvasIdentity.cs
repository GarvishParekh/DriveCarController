using UnityEngine;


public class CanvasIdentity : MonoBehaviour
{
    [SerializeField] private CanvasNames myCanvas;

    public CanvasNames GetCanvasName()
    {
        return myCanvas;
    }
}

public enum CanvasNames
{
    MAIN_MENU,
    GARAGE,
    GAMEPLAY,
    PAUSE,
    GAMEOVER,
    OPTIONS,
    SHOP,
    LEVEL_SELECTION,
    UPDATE,
    LEADERBOARDS,
    ENTER_USER_NAME,
    NEWS_CANVAS
}
