using Unity.VisualScripting;
using UnityEngine;

public class NPCWaitCommand : ICommand
{
    private bool _isComplete;
    public bool IsComplete => _isComplete;

    private float _timer;

    private float _timeToComplete;

    private bool _isTimerRunning;

    public NPCWaitCommand (float timeToWait)
    {
        _timeToComplete = timeToWait;
        _isTimerRunning = false;
    }

    public void Execute() /*This is an Update method for this code*/
    {
        Debug.Log("Wait Command started");
        if (!_isTimerRunning && !_isComplete)
        {
            InitiateWait();
        }

        if (_isTimerRunning)
        {
            _timer += Time.deltaTime;
                if (_timer >= _timeToComplete)
            {
                _isComplete = true;
                _isTimerRunning = false;
            }
        }
    }

    public void InitiateWait()
    {
        _timer = 0;
        _isTimerRunning = true;
    }
}
