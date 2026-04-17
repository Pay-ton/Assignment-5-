using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BumperLeft : MonoBehaviour
{

    public Quaternion startRotation;
    public Quaternion endRotation;
    public GameObject Disc;
    public GameObject BumperPosition;
    public bool flipped;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startRotation = transform.rotation;
        if (flipped)
        {
            endRotation.eulerAngles = new Vector3(0, 0, -45);
        }
        else
        {
            endRotation.eulerAngles = new Vector3(0, 0, 90);
        }
        endRotation *= startRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Disc = GameObject.Find("Disc(Clone)");


        // For the left bumper movemen/ stuffs  wooyeah
        if (Disc != null && Input.GetKey(KeyCode.A) && !flipped)


        {

            transform.rotation = Quaternion.Lerp(transform.rotation, endRotation, 90 * Time.deltaTime);

            if (BumperPosition.GetComponent<Collider2D>().IsTouching(Disc.GetComponent<Collider2D>()))
            {

                Disc.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 250),ForceMode2D.Impulse);
            }


        }
        if (Disc != null && Input.GetKey(KeyCode.D) && flipped)


        {
            // For the Right Bumper movement/input
            transform.rotation = Quaternion.Lerp(transform.rotation, endRotation, 90 * Time.deltaTime);

            if (BumperPosition.GetComponent<Collider2D>().IsTouching(Disc.GetComponent<Collider2D>()))
            {

                Disc.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 250), ForceMode2D.Impulse);
            }


        }
        else
        {

            //This should make it go back to start when no inputs are given

            transform.rotation = Quaternion.Lerp(transform.rotation, startRotation, 90 * Time.deltaTime);

        }


    }
}
