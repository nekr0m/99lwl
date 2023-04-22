using UnityEngine;
using System.Collections.Generic;
public class Move : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] Rigidbody2D Body;
    [SerializeField] GameObject Item;
    [SerializeField] GameObject Item2;
    [SerializeField] GameObject WinLose;
    [SerializeField] Animator Anim;
    public SpriteRenderer Face;
    Vector3 Movement;
    public bool Ground;
    public bool Hide;
    public bool Breathing;
    public int Poison;
    public GameObject CanTake;
    GameObject Droped;
    List<GameObject> AllBox = new List<GameObject>();
    bool Magic;
    bool Take;
    float Timer;
    public void Teleport(bool a)
    {
        transform.position = new Vector3(Man.data.X, Man.data.Y, 0);
        if (!a)
        {
            Man.data.X = PlayerPrefs.GetFloat("X");
            Man.data.Y = PlayerPrefs.GetFloat("Y");
        }
        if (AllBox.Count > 0)
        {
            for (int i = 0; i < AllBox.Count; i++) Destroy(AllBox[i]);
            AllBox.Clear();
        }
    }
    void Update()
    {
        if (Man.data.Live == 1)
        {
            Movement = Vector3.zero;
            if (Ground)
            {
                if (Anim.GetInteger("GG") == 4) Man.aud.PlaySound(2);
                Anim.SetInteger("GG", 0);
            }
            if (Timer <= 0.5f && !Ground) Anim.SetInteger("GG", 4);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Man.data.SkillUsed == 0)
                {
                    if (Man.data.Energy / Data.MaxEnergy >= 0.3f) Man.skill.SkillUsed();
                }
                else Man.skill.SkillOff();
            }
            if (Input.GetKeyDown(KeyCode.Space) && Timer <= 0 && Ground)
            {
                Timer++;
                Man.aud.PlaySound(1);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (Take)
                {
                    Vector3 NewPos = transform.position + new Vector3(transform.localScale.x, 0, 0);
                    if (Magic) Droped = Instantiate(Item2);
                    else Droped = Instantiate(Item);
                    AllBox.Add(Droped);
                    Droped.transform.position = NewPos;
                    Take = false;
                    Magic = false;
                }
                if (CanTake != null)
                {
                    Take = true;
                    if (CanTake.tag == "Box2" || CanTake.tag == "Switcer2") Magic = true;
                    if (CanTake.tag == "Box" || CanTake.tag == "Box2")
                    {
                        for (int i = 0; i < AllBox.Count; i++) if (AllBox[i] == CanTake) AllBox.RemoveAt(i);
                        Destroy(CanTake);
                    }
                    else CanTake.SetActive(false);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                Movement.x = -Data.Speed;
                transform.localScale = new Vector3(-1, 1, 1);
                if (Ground)
                {
                    if (Man.data.SkillUsed == 0) Anim.SetInteger("GG", 1);
                    else Anim.SetInteger("GG", 2);
                    if (Poison > 0) Anim.SetInteger("GG", 5);
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                Movement.x = Data.Speed;
                transform.localScale = new Vector3(1, 1, 1);
                if (Ground)
                {
                    if (Man.data.SkillUsed == 0) Anim.SetInteger("GG", 1);
                    else Anim.SetInteger("GG", 2);
                    if (Poison > 0) Anim.SetInteger("GG", 5);
                }
            }
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
                if (Timer > 0.5f)
                {
                    Movement.y = Data.Jump;
                    Anim.SetInteger("GG", 3);
                }
            }
            Body.velocity = Movement * Man.data.ActiveSkill;
            if (Man.data.SleepValue > -1)
            {
                if (Movement.x != 0 || Movement.y != 0) Man.data.DeepSleep = true;
                else Man.data.DeepSleep = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D body)
    {
        if (body.gameObject.tag == "Switcer" && !Take || body.gameObject.tag == "Switcer2" && !Take || body.gameObject.tag == "Box" && !Take || body.gameObject.tag == "Box2" && !Take) CanTake = body.gameObject;
    }
    void OnCollisionExit2D(Collision2D body)
    {
        if (body.gameObject.tag == "Switcer" || body.gameObject.tag == "Switcer2" || body.gameObject.tag == "Box" || body.gameObject.tag == "Box2") CanTake = null;
    }
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "Poison")
        {
            if (gameObject.tag == "GG" || gameObject.tag == "Hide") LoseGame(1);
            Man.data.ActiveSkill = 1.5f;
            Poison++;
        }
        if (body.gameObject.tag == "Hide")
        {
            Face.color = new Color(1, 1, 1, 0.5f);
            gameObject.tag = "Hide";
            Hide = true;
        }
        if (body.gameObject.tag == "Sleep")
        {
            Man.data.SleepValue = body.gameObject.GetComponent<Sleep>().Value;
            Man.data.DeepSleep = true;
        }
        if (body.gameObject.tag == "Enemy" && gameObject.tag == "GG") LoseGame(0);
        if (body.gameObject.tag == "Finder" && gameObject.tag == "GG" || body.gameObject.tag == "Finder" && gameObject.tag == "GGHide") LoseGame(0);
        if (body.gameObject.tag == "Item" && Man.data.QvestCompleted == 0) Man.data.QvestCompleted = 1;
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "Hide")
        {
            if (Man.data.SkillUsed == 0)
            {
                Face.color = new Color(1, 1, 1, 1);
                gameObject.tag = "GG";
            }
            else gameObject.tag = "GGHide";
            Hide = false;
        }
        if (body.gameObject.tag == "Poison")
        {
            Man.data.ActiveSkill = 0.5f;
            Poison--;
        }
        if (body.gameObject.tag == "Sleep")
        {
            Man.data.SleepValue = -1;
            Man.data.DeepSleep = false;
        }
        if (body.gameObject.tag == "Finder") Man.data.SleepValue = -1;
    }
    public void LoseGame(int a)
    {
        if (a == 0) Man.ui.WinLoseInfo.text = "You've been caught";
        if (a == 1) Man.ui.WinLoseInfo.text = "You are suffocating";
        Man.data.Live = 0;
        Man.aud.PlayMuz(Man.data.Muz.Length - 1);
        Face.enabled = false;
        WinLose.SetActive(true);
    }
}
