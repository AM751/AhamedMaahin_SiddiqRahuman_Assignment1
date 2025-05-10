using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController playerController;
    private Vector3 playerVelocity;
    private bool playerGrounded;
    public float playerSpeed = 10f;
    //private float playerJumpHeight = 5f;



    private void Start()
    {
        //To assign the playerController as the CharcaterController:

        playerController = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    //To check whether the player is grounded?
    {
        playerGrounded = playerController.isGrounded;
        if (playerGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        //For the Movement of the player deirections:
        Vector3 movementSides = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        playerController.Move(movementSides * playerSpeed * Time.deltaTime);

    }
}
