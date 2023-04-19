using UnityEngine;
public class Location : MonoBehaviour
{
    [SerializeField] LocalSwitcher ls;
    [SerializeField] int Value;
    [SerializeField] int Port;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide") ls.Teleport(Value, Port);
    }
}
