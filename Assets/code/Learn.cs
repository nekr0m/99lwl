using UnityEngine;
public class Learn : MonoBehaviour
{
    [SerializeField] Ui ui;
    [SerializeField] GameObject Hint;
    [SerializeField] int value;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG")
        {
            a();
            Hint.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG") Hint.SetActive(false);
    }
    void a()
    {
        if (value == 0) ui.Learn.text = "";
        if (value == 1) ui.Learn.text = "";
        if (value == 2) ui.Learn.text = "";
        if (value == 3) ui.Learn.text = "";
        if (value == 4) ui.Learn.text = "";
        if (value == 5) ui.Learn.text = "";
        if (value == 6) ui.Learn.text = "";
        if (value == 7) ui.Learn.text = "";
        if (value == 8) ui.Learn.text = "";
        if (value == 9) ui.Learn.text = "";
        if (value == 10) ui.Learn.text = "";
    }
}
