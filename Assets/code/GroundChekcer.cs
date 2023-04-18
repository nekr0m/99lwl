using UnityEngine;
public class GroundChekcer : MonoBehaviour
{
    [SerializeField] Manadger Man;
    void OnTriggerStay2D(Collider2D body)
    {
        if (body.gameObject.tag == "Ground" || body.gameObject.tag == "Switcer" || body.gameObject.tag == "Switcer2" || body.gameObject.tag == "Box" || body.gameObject.tag == "Box2") Man.move.Ground = true;
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "Ground" || body.gameObject.tag == "Switcer" || body.gameObject.tag == "Switcer2" || body.gameObject.tag == "Box" || body.gameObject.tag == "Box2") Man.move.Ground = false;
    }
}
