using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
    {
        ScoreCounter.scoreAmount += 1;
    }
}
