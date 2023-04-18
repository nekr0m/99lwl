using UnityEngine;
public class LocalSwitcher : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] Transform[] Pos; //2
    [SerializeField] GameObject[] Room0;
    [SerializeField] GameObject[] Room1;
    [SerializeField] GameObject[] Room2;
    [SerializeField] GameObject[] Room3;
    [SerializeField] GameObject[] Room4;
    [SerializeField] GameObject[] Room5;
    [SerializeField] GameObject[] Room6;
    [SerializeField] GameObject[] Room7;
    [SerializeField] GameObject[] Room8;
    [SerializeField] GameObject[] Room9;
    int OldMuz;
    void Start()
    {
        Areas(); 
        Areas(true);
    }
    public void Teleport(int a, int b)
    {
        Areas(false);
        Man.data.Port += a;
        Areas(true);
        Areas();
        Man.data.X = Pos[b].position.x;
        Man.data.Y = Pos[b].position.y;
        Man.move.Teleport(false);
    }
    void Areas()
    {
        if (Man.data.Port - 1 > -1) Man.ui.BackArea.text = $"{Man.data.Port - 1}\nAREA";
        else Man.ui.BackArea.text = "NEXT\nLWL";
        Man.ui.ForvardArea.text = $"{Man.data.Port + 1}\nAREA";
    }
    void Areas(bool a)
    {
        if (Man.data.Port == 0) Teleport(Room0, a);
        if (Man.data.Port == 1) Teleport(Room1, a);
        if (Man.data.Port == 2) Teleport(Room2, a);
        if (Man.data.Port == 3) Teleport(Room3, a);
        if (Man.data.Port == 4) Teleport(Room4, a);
        if (Man.data.Port == 5) Teleport(Room5, a);
        if (Man.data.Port == 6) Teleport(Room6, a);
        if (Man.data.Port == 7) Teleport(Room7, a);
        if (Man.data.Port == 8) Teleport(Room8, a);
        if (Man.data.Port == 9) Teleport(Room9, a);

        if (!a) OldMuz = Man.data.Port;
        if (Man.data.Port == 0 && a) Man.aud.PlayMuz(0);
        if (Man.data.Port == 1 && OldMuz == 0 && a) Man.aud.PlayMuz(1);
    }
    void Teleport(GameObject[] a, bool b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i].SetActive(b);
        }
    }
}
//public class LocalSwitcher : MonoBehaviour
//{
//    [SerializeField] Manadger Man;
//    [SerializeField] Location[] Loc; //Room = Loc % 10;
//    [SerializeField] Transform[] Pos;
//    [SerializeField] GameObject[] Room;
//    int TimerLimit = 20;
//    float Timer;
//    void Update()
//    {
//        Timer -= Time.deltaTime;
//        if (Timer < 0)
//        {
//            Timer = TimerLimit;
//            for (int i = 0; i < Loc.Length; i++)
//            {
//                if (Loc[i].LocValue.Length > 1) Loc[i].Value = Loc[i].LocValue[Random.Range(0, Loc[i].LocValue.Length)];
//            }
//        }
//    }
//    public void Teleport()
//    {
//        int a = Man.data.Port % 10;
//        for (int i = 0; i < Room.Length; i++)
//        {
//            if (i == a) Room[i].SetActive(true);
//            else Room[i].SetActive(false);
//        }
//        Man.data.X = Pos[Man.data.Port].position.x;
//        Man.data.Y = Pos[Man.data.Port].position.y;
//        Man.move.Teleport();
//    }
//}
