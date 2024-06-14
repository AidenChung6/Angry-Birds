using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public LineRenderer[] lineRenderers;
    public Transform[] stringPositions;
    public Transform center;
    public Transform IdlePosition;

    public Vector3 currentPosition;

    public float maxLength;//This limits how far the string can extend.

    public float bottomBoundary;

    bool isMouseDown;//This checks if the user mouse is pressed down.

    public GameObject birdPrefab;

    public float birdPositionOffset;

    Rigidbody2D bird;
    Collider2D birdCollider;

    public float force; 

    void Start()
    {
        lineRenderers[0].positionCount = 2;
        lineRenderers[1].positionCount = 2;
        lineRenderers[0].SetPosition(0, stringPositions[0].position);
        lineRenderers[1].SetPosition(0, stringPositions[1].position);
        CreateBird();
    }

    void CreateBird()
    {
        bird = Instantiate(birdPrefab).GetComponent<Rigidbody2D>();
        birdCollider = bird.GetComponent<Collider2D>();
        birdCollider.enabled = false;

        bird.isKinematic = true;

        resetString();
    }

    void Update()
    {
        if(isMouseDown){//This gets the position of the mouse when it is held down and moves the string to that position.
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;

            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = center.position + Vector3.ClampMagnitude(currentPosition - center.position, maxLength);

            currentPosition = ClampBoundary(currentPosition);

            setString(currentPosition);

            if(birdCollider)
            {
                birdCollider.enabled = true;
            }
        }
        else{//This cause the string to go back to the idle position when the mouse is let go.
            resetString();
        }
    }

    private void OnMouseDown()
    {
        isMouseDown = true;
    }

    private void OnMouseUp()
    {
        isMouseDown = false;
        Shoot();
    }

    void Shoot()
    {
        bird.isKinematic = false;
        Vector3 birdForce = (currentPosition - center.position) * force * -1;
        bird.velocity = birdForce;

        bird = null;
        birdCollider = null;
        Invoke("CreateBird", 2);
        
    }

    void resetString()//This resets the string to its orignal position.
    {
        currentPosition = IdlePosition.position;
        setString(currentPosition);
    }

    void setString(Vector3 position)
    {
        lineRenderers[0].SetPosition(1, position);
        lineRenderers[1].SetPosition(1, position);

        if(bird)
        {
            Vector3 dir = position - center.position;
            bird.transform.position = position + dir.normalized * birdPositionOffset;
            bird.transform.right = -dir.normalized;
        }
    }

    Vector3 ClampBoundary(Vector3 vector)
    {
        vector.y = Mathf.Clamp(vector.y, bottomBoundary, 1000);
        return vector;
    }
}
