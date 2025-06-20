using UnityEngine;

public class PlayerStratManager : MonoBehaviour
{

    [SerializeField] private PointAndClickManager _pointAndClickManager;

    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerBuilder _playerBuilder;
    [SerializeField] private PlayerTerminalInteractor _terminalInteractor;

    public PlayerMover mPlayerMover => _playerMover;
    public PlayerBuilder mPlayerBuilder => _playerBuilder;
    public PlayerTerminalInteractor mPlayerInteractor => _terminalInteractor;

    //Creating references for the Strategies:
    private PlayerMoveStrategy _playerMoveStrategy;
    private PlayerBuildStrategy _playerBuildStrategy;
    private PlayerTerminalStrategy _playerTerminalStrategy;

    //To know the current Strategy:
    private IStrategy _currentStrategy;

    public Vector3 ClickedPoint { get; private set; }

    public IClickable ClickedTarget { get; private set; }

    private void Awake()
    {
        _playerMoveStrategy = new PlayerMoveStrategy (this);
        _playerBuildStrategy = new PlayerBuildStrategy(this);
        _playerTerminalStrategy = new PlayerTerminalStrategy(this);
    }

    private void OnEnable()
    {
        _pointAndClickManager.OnClicked += ExecuteStrategy;
    }

    private void OnDisable()
    {
        _pointAndClickManager.OnClicked -= ExecuteStrategy;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ExecuteStrategy(Vector3 clickedPoint, IClickable clickedTarget)
    {
        ClickedPoint = clickedPoint;
        ClickedTarget = clickedTarget;
        _currentStrategy?.Execute() ;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentStrategy = _playerMoveStrategy;
            Debug.Log("He's Moving");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _currentStrategy = _playerBuildStrategy;
            Debug.Log("He's Building");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _currentStrategy = _playerTerminalStrategy;
            Debug.Log("Heyya Terminal");
        }

    }
}

