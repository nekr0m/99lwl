using UnityEngine;
public class NextLwl : MonoBehaviour
{
    [SerializeField] Manadger Man;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide")
        {
            Man.data.NewLwl = true;
            Man.GoTo(Man.data.Lwl + 1);
        }
    }
}
