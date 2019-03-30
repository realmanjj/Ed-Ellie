using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jump : MonoBehaviour
{

    [SerializeField] Image jumpForceBar;
    public static Rigidbody2D rb;
    float touchStartTime = 0f;
    public float speed = 1.5f;


    // Use this for initialization
    void Start()
    {
        jumpForceBar.fillAmount = 0f;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            touchStartTime = Time.time;
            jumpForceBar.fillAmount = Time.time;
            jumpForceBar.fillAmount = 1f;
           
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            float delta = Time.time - touchStartTime;
            float adjustedSpeed = speed * delta;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * adjustedSpeed);
            jumpForceBar.fillAmount = 0f;
            
        }
    }

    

}
