using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public GameObject discPrefab;
    private GameObject currentDisc = null;
    public Score score;

    void Update()
    {
        // Below is commented out because I cannot figure out how to do this. 

        // Move player horizontally
        //float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //Vector3 position = transform.position;
        //position.x += moveX;
        //transform.position = position;

        // Drop disc
        if (Input.GetKeyDown(KeyCode.Space) && currentDisc == null)
        {
            // Clone prefab
            currentDisc = Instantiate(discPrefab, transform.position, Quaternion.identity);
            score.ScoreReset();
            
        }
    }
}
