using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGRepeater : MonoBehaviour
{
    public float speed;

    public float xStart;
    public float xend;


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(transform.position.x <= xend)
        {
            Vector2 pos = new Vector2(xStart, transform.position.y);
            transform.position = pos;
        }
    }
}
