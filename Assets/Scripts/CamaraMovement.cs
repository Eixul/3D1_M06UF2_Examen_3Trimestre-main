using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    
    private Transform target;
    public Vector2 limitX;
    public Vector2 limitY;

    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Mario").GetComponent<Transform>();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        transform.position = desiredPosition;

        float clampX = Mathf.Clamp(desiredPosition.x, limitX.x, limitX.y);
        float clampY = Mathf.Clamp(desiredPosition.y, limitY.x, limitY.y);

        Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);

        transform.position = clampedPosition;

    }
}
