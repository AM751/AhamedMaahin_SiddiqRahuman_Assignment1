using TMPro;
using UnityEngine;

public class PlayerBuildStrategy : IStrategy
{
    private PlayerStratManager _stratManager;
    public PlayerBuildStrategy (PlayerStratManager manager)
    {
        _stratManager = manager;
    }
    public void Execute()
    {
        Debug.Log ("Player is building something... haha");
        _stratManager.mPlayerBuilder.Build (_stratManager.ClickedPoint);
    }
}
