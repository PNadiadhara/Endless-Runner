using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private Vector2 targetPos;
    public float YIncrement;
    public float speed;
    //ScreenLimits
    public float maxHeight;
    public float minHeight;

    // Update is called once per frame
    void Update()
    {
        //Character sprite glides on screen instead of snapping
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {            
            targetPos = new Vector2(transform.position.x,transform.position.y + YIncrement);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement); 
        }
    }
}
