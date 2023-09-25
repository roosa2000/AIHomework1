using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        faceClick();

        if(Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    void faceClick()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x = transform.position.x,
            mousePosition.y = transform.position.y
        );

        transform.up = direction;
    }
}
