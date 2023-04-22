using UnityEngine;
public class Skill : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] GameObject Breath;
    void Update()
    {
        if (Man.data.Live == 1)
        {
            if (Man.data.SkillUsed == 0 && Man.data.Energy < Data.MaxEnergy)
            {
                Man.data.Energy += Data.EnergyRegen * Time.deltaTime;
                Man.ui.Energy.fillAmount = Man.data.Energy / Data.MaxEnergy;
                if (Man.data.Energy > Data.MaxEnergy)
                {
                    Man.data.Energy = Data.MaxEnergy;
                    Breath.SetActive(false);
                }
            }
            if (Man.data.SkillUsed == 1)
            {
                Man.data.Energy -= Time.deltaTime;
                Man.ui.Energy.fillAmount = Man.data.Energy / Data.MaxEnergy;
                if (Man.data.Energy <= 0) SkillOff();
            }
        }
    }
    public void SkillUsed()
    {
        Man.aud.PlaySound(0);
        Breath.SetActive(true);
        Man.data.SkillUsed = 1;
        Man.data.ActiveSkill = 0.5f;
        Man.move.Face.color = new Color(1, 1, 1, 0.5f);
        if (gameObject.tag == "GG") gameObject.tag = "GGHide";
    }
    public void SkillOff()
    {
        Man.aud.PlaySound(3);
        Man.data.SkillUsed = 0;
        Man.data.ActiveSkill = 1;
        if (!Man.move.Hide)
        {
            Man.move.Face.color = new Color(1, 1, 1, 1);
            gameObject.tag = "GG";
        }
        else gameObject.tag = "Hide";
        if (Man.move.Poison > 0) Man.move.LoseGame(1);
    }
}
