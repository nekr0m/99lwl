using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    [SerializeField] Animator Anim;
    public int pos;
    bool b;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && b)
        {
            if (pos == 4) pos = 0;
            if (pos == 0)
            {
                Anim.SetInteger("up", 1);
                pos++;
            }
            if (pos == 2)
            {
                Anim.SetInteger("up", 2);
                pos++;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide") b = true;
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide") b = false;
    }
}
