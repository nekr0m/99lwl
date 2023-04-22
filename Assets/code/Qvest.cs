using UnityEngine;
public class Qvest : MonoBehaviour
{
    [SerializeField] Manadger Man;
    public bool Help;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!Help) QSay();
            else
            {
                Man.ui.qv.text = "";
                Help = false;
            }
            Man.Hi.Value2 = 0;
        }
    }
    public void QSay()
    {
        int a = Man.data.Qvest;
        if (a == 1) Man.ui.qv.text = "Find a book";
        if (a == 2) Man.ui.qv.text = "Find the tools";
        if (a == 3) Man.ui.qv.text = "Find sheet music";
        if (a == 4) Man.ui.qv.text = "";
        if (Man.data.QvestCompleted == -1) Man.ui.qv.text = "Explore the area";
        if (Man.data.QvestCompleted == 1) Man.ui.qv.text = "Task completed";
        if (Man.data.QvestCompleted == 2) Man.ui.qv.text = "The door is open";
        Help = true;
    }
}
