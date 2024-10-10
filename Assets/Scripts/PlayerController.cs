using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 5.0f;          // Set the jump force for the player
    public float gravityModifier = 1.0f;    // Set a custom gravity modifier
    public bool isOnGround = true;          // Track if the player is on the ground

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        // Adjust the gravity by multiplying it with the gravityModifier
        Physics.gravity *= gravityModifier;

        // Make the player jump at the start of the game
        playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;  // Player is not on the ground after the initial jump
    }

    void Update()
    {
        // Check if the spacebar is pressed and if the player is on the ground
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            // Make the player jump
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;  // Set isOnGround to false, as the player is now in the air
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with the ground
        isOnGround = true;
    }
}
