using UnityEngine;
public class SavePoint : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] GameObject Activate;
    [SerializeField] bool Item;
    int TimerLimit = 1;
    float Timer;
    void Update()
    {
        if (Timer > 0) Timer -= Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D body)
    {
        if (Item && Man.data.QvestCompleted != 0) gameObject.SetActive(false);
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "Hide" || body.gameObject.tag == "GGHide")
        {
            if (Timer <= 0 && !Item || Item)
            {
                Man.data.X = gameObject.transform.position.x;
                Man.data.Y = gameObject.transform.position.y;
                Man.save.Save();
                GameObject NewBoom = Instantiate(Activate);
                NewBoom.transform.position = transform.position;
                if (Item) gameObject.SetActive(false);
                Timer = TimerLimit;
            }
        }
    }
}
