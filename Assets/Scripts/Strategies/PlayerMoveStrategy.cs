using UnityEngine;

public class PlayerMoveStrategy : IStrategy
{

    PlayerMover _playerMover;
    PlayerStratManager strategyManager;

    public PlayerMoveStrategy (PlayerStratManager manager)
    {
        strategyManager = manager;
    }
    public void Execute()
    {
        //Debug.Log("Player Should Move Now");
        //Check for the Floor
        if (strategyManager.ClickedTarget.GetType() != typeof(Floor)) return;

        //For Moving the player towards the clickpoint:
        strategyManager.mPlayerMover.MovePlayer(strategyManager.ClickedPoint);
    }
}
