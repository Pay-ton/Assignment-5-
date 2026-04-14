using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float LaunchSpeed = 20.0f;
    float moveY;
    Vector3 position;
    private Vector3 startPosition;
    private Quaternion startRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        // This is copied and changed from the initial player script, to (hopefully) allow for
        // launching the ball via a movement and collision script with the ball. 
        // Launch Player

        
       

        // This should allow the ball to spawn when spacebar is pressed, then have the ball launch 
        // when spacebar is released.
        if (Input.GetButtonUp(KeyCode.Space))
        {
            moveY = position.y *Time.deltaTime * LaunchSpeed;
            transform.position =
            position.x += moveY;
            transform.position = position;

        }
        else
        {
            //GoBackToStart 
        }


    }
}
