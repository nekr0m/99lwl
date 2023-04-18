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
//public class Location : MonoBehaviour
//{
//    [SerializeField] Manadger Man;
//    [SerializeField] Text Num;
//    public int[] LocValue;
//    public int Value;
//    void OnTriggerEnter2D(Collider2D body)
//    {
//        if (body.gameObject.tag == "GG") Man.data.Port = Value;
//    }
//    void OnTriggerExit2D(Collider2D body)
//    {
//        if (body.gameObject.tag == "GG") Man.data.Port = -1;
//    }
//    public void Switcher()
//    {
//        Value = LocValue[Random.Range(0, LocValue.Length)];
//        Num.text = $"{Value % 10}";
//    }
//}
