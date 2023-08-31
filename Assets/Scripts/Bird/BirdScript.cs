using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    [SerializeField] float flapStrength = 2;
    [SerializeField] int lives = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * flapStrength * 10;
        }
        // Get the current position of the object along the Y-axis
        float yPosition = transform.position.y;

        // Calculate the rotation angle based on the Y-axis position
        float rotationAngle = yPosition * 10;

        // Create a rotation quaternion around the Z-axis
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(rotationAngle,-50f,50f));

        // Apply the rotation to the object's transform
        transform.rotation = targetRotation;
    }

    public void OnDeaths()
    {
        Debug.Log($"Lives Left: {lives}");
        lives--;
    }
    public int LivesLeft()
    {
        return lives;
    }
}
