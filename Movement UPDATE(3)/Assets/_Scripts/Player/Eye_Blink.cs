using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBlinking : MonoBehaviour
{
    public Animator anim;
    public float minBlinkTime, maxBlinkTime;
    bool looping = true;

    void Start()
    {
        StartCoroutine(blinking());
    }
    IEnumerator blinking()
    {
        while (looping == true)
        {
            yield return new WaitForSeconds(Random.Range(minBlinkTime, maxBlinkTime));
            anim.SetTrigger("blink");
        }
    }
}