using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour

    
{
   

    public GameObject effect;
    private Vector2 targetPos;
    private shake shake;

    public float YIncrement;
    public float speed;
    //ScreenLimits
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    // health
    public Text healthText;

    public GameObject gameOver;
    
    
    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString(); 
          
        //Character sprite glides on screen instead of snapping
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x,transform.position.y + YIncrement);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement); 
        }
    }
}
