using UnityEngine;
using UnityEngine.UI;
public class Sleep : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] GameObject Snore;
    [SerializeField] Image Face;
    public int Value;
    int TimerLimit = 5;
    float Timer = 5;
    void Update()
    {
        if (Timer < TimerLimit || Man.data.DeepSleep && Man.data.SleepValue == Value)
        {
            if (Man.data.DeepSleep && Man.data.SkillUsed == 0 && Man.data.SleepValue == Value) Timer -= 5 * Time.deltaTime;
            else Timer += Time.deltaTime;
            if (Timer > TimerLimit) Timer = TimerLimit;
            if (Timer <= 0) Man.move.LoseGame(0);
            Face.fillAmount = Timer / TimerLimit;
            if (Timer == TimerLimit) Snore.SetActive(false);
            else Snore.SetActive(true);
        }
    }
}
