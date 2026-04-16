using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BallLauncher : MonoBehaviour
{
    public float LaunchSpeed = 20.0f;
    Vector3 position;
    public Vector3 startPosition;
    public Quaternion startRotation;
    public Vector3 endPosition;
    public Quaternion endRotation;
    public GameObject Disc;
    public GameObject InLaunchPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Disc = GameObject.Find("Disc(Clone)");


        // This should allow the ball to spawn and launch when spacebar is pressed
        if (Disc != null && Input.GetKey(KeyCode.Space) && InLaunchPosition.GetComponent<Collider2D>().IsTouching(Disc.GetComponent<Collider2D>()))

        {

            transform.position = Vector3.Lerp(transform.position, endPosition, LaunchSpeed * Time.deltaTime);
            Disc.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
        }
        else
        {

            //This should make it go back to start when the spacebar isn't being held. 
            transform.position = startPosition;
            transform.rotation = startRotation;
        }


    }
}
