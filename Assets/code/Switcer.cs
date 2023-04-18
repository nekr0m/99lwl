using UnityEngine;
public class Switcer : MonoBehaviour
{
    [SerializeField] GameObject Door;
    [SerializeField] SpriteRenderer Button;
    [SerializeField] bool Magic;
    int Presed;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (Magic)
        {
            if (body.gameObject.tag == "Switcer2" || body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide" || body.gameObject.tag == "Box2")
            {
                Presed++;
                if (Presed > 0)
                {
                    Door.SetActive(false);
                    Button.enabled = false;
                }
            }
        }
        else
        {
            if (body.gameObject.tag == "Switcer" || body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide" || body.gameObject.tag == "Box")
            {
                Presed++;
                if (Presed > 0)
                {
                    Door.SetActive(false);
                    Button.enabled = false;
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (Magic)
        {
            if (body.gameObject.tag == "Switcer2" || body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide" || body.gameObject.tag == "Box2")
            {
                Presed--;
                if (Presed == 0)
                {
                    Door.SetActive(true);
                    Button.enabled = true;
                }
            }
        }
        else
        {
            if (body.gameObject.tag == "Switcer" || body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide" || body.gameObject.tag == "Box")
            {
                Presed--;
                if (Presed == 0)
                {
                    Door.SetActive(true);
                    Button.enabled = true;
                }
            }
        }
    }
}
