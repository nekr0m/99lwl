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
                Man.ui.Info.text = "";
                Help = false;
            }
            Man.Hi.Value2 = 0;
        }
    }
    public void QSay()
    {
        int a = Man.data.Qvest;
        if (a == 1) Man.ui.Info.text = "Long ago, I lost a book that I need for my research, and it's located on the other side.";
        if (a == 2) Man.ui.Info.text = "Can you get the tools for me?";
        if (a == 3) Man.ui.Info.text = "Could you please retrieve my sheet music?";
        if (a == 4) Man.ui.Info.text = "";
        if (Man.data.QvestCompleted == -1) Man.ui.Info.text = "Talk to the fairy";
        if (Man.data.QvestCompleted == 1) Man.ui.Info.text = "Great, now talk to the fairy!";
        if (Man.data.QvestCompleted == 2) Man.ui.Info.text = "Well done! Now go to the next level!";
        Help = true;
    }
}
