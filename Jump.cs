using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{

    [SerializeField] Image jumpForceBar;
    public static Rigidbody2D rb;
    float holdTime;
   
     
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpForceBar.fillAmount = 0f;
    }
    
        void Update()
        {       
           if (Input.GetKey(KeyCode.Space))
           {
            StartCoroutine("StartCounting");
            jumpForceBar.fillAmount = 0f;
           }
           
           if (Input.GetKeyUp(KeyCode.Space))
           {
            StopCoroutine("StopCounting");

            if (holdTime < 0.2f)
                Ed.DoJump(20f);
            else
                Ed.DoJump(holdTime * 95f);

            jumpForceBar.fillAmount = 0f;
        }
    }

    IEnumerator StartCounting()
    {
        for (holdTime = 0f; holdTime <= 1f; holdTime += Time.deltaTime)
        {
            jumpForceBar.fillAmount = holdTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        holdTime = 1f;
        jumpForceBar.fillAmount = holdTime;
    }
}
