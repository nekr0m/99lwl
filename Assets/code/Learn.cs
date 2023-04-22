using UnityEngine;
public class Learn : MonoBehaviour
{
    [SerializeField] Ui ui;
    [SerializeField] GameObject Hint;
    [SerializeField] int value;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide")
        {
            a();
            Hint.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG" || body.gameObject.tag == "GGHide") Hint.SetActive(false);
    }
    void a()
    {
        if (value == 0) ui.Learn.text = "Press \"A\" or \"D\" to move";
        if (value == 1) ui.Learn.text = "Press \"Spacebar\" to jump";
        if (value == 2) ui.Learn.text = "Press \"W\" to talk";
        if (value == 3) ui.Learn.text = "Press \"E\" for silent mode";
        if (value == 4) ui.Learn.text = "Press \"F\" to take / drop a the box";
        if (value == 5) ui.Learn.text = "Press \"R\"";
        if (value == 99) ui.Learn.text = "Press “Q” to view the quest.";
    }
}