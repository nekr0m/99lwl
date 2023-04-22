using UnityEngine;
using UnityEngine.UI;
public class Ui : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] Slider Sl;
    public Image WinLose;
    public Image Energy;
    public Text WinLoseInfo;
    public Text Info;
    public Text qv;
    public Text Learn;
    public Text BackArea;
    public Text ForvardArea;
    public void Volume()
    {
        Man.data.Volume = Sl.value;
        Man.aud.Volume(Man.data.Volume);
    }
    public void Volume(float a)
    {
        Sl.value = a;
    }
}
