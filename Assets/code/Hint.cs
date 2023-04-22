using UnityEngine;
public class Hint : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] GameObject Wall;
    [SerializeField] int[] Value;
    public int Value2;
    bool CanSay;
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG")
        {
            CanSay = true;
            Value2 = 0;
        }
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.tag == "GG")
        {
            CanSay = false;
            Man.ui.Info.text = "";
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && CanSay)
        {
            if (Man.data.QvestCompleted > 0)
            {
                if (Value2 < Value[3])
                {
                    Say2();
                    Value2++;
                }
                else
                {

                    if (Value2 == Value[3])
                    {
                        Man.data.QvestCompleted = 2;
                        Wall.SetActive(false);
                        Man.ui.Info.text = "The door is open";
                        Value2++;
                    }
                    else
                    {
                        Value2 = 0;
                        Man.ui.Info.text = "";
                    }
                }
            }
            else
            {
                if (Value2 < Value[1])
                {
                    Say();
                    Value2++;
                }
                else
                {

                    if (Man.data.QvestCompleted == -1)
                    {
                        Man.data.Qvest = Man.data.Lwl;
                        Man.data.QvestCompleted = 0;
                        Man.Qv.QSay();
                    }
                    else
                    {
                        Value2 = 0;
                        Man.ui.Info.text = "";
                    }
                }
            }
            Man.Qv.Help = false;
        }
    }
    void Say()
    { 
        int a = Value2 + Value[0];
        //1
        if (a == 0) Man.ui.Info.text = "Lord, what kind of trouble is happening in these lands?";
        if (a == 1) Man.ui.Info.text = "I was told that the inhabitants of Atlantis were wise and powerful, but now all I see is destruction and devastation.";
        if (a == 2) Man.ui.Info.text = "And how did you, strange stone man, end up here?";
        if (a == 3) Man.ui.Info.text = "But never mind, that's not important. You need a key, right?";
        if (a == 4) Man.ui.Info.text = "I can give you one, but I need your help.";
        if (a == 5) Man.ui.Info.text = "Long ago, I lost a book that I need for my research, and it's located on the other side. I can't get there because of the poisonous plants. If you retrieve it for me, the key will be yours.";
        //2
        if (a == 6) Man.ui.Info.text = "Ah, it's so difficult to work in such a world. Nobody appreciates my work, nobody cares about their shoes.";
        if (a == 7) Man.ui.Info.text = "And here I am, standing, contemplating my fate, while my work waits for me. But you, strange stone man, you understand how I feel.";
        if (a == 8) Man.ui.Info.text = "I see that you have your own problems, but I can help you if you help me.";
        if (a == 9) Man.ui.Info.text = "I need tools to continue working, but I'm afraid to pass through those monsters.";
        if (a == 10) Man.ui.Info.text = "Can you get the tools for me? Once I finish, I'll give you new boots that will help you remain unnoticed.";
        //3
        if (a == 11) Man.ui.Info.text = "Hello, strange stone figure! I am so glad to finally meet someone who can help me.";
        if (a == 12) Man.ui.Info.text = "I lost my little harp and now I can't play music.";
        if (a == 13) Man.ui.Info.text = "I know it may seem unimportant compared to other problems in Atlantis, but it is very important to me.";
        if (a == 14) Man.ui.Info.text = "I am willing to help you if you help me. But be careful, monsters can be very dangerous.";
        if (a == 15) Man.ui.Info.text = "Could you please retrieve my harp?";
        if (a == 16) Man.ui.Info.text = "I can't give you anything in return, but right now I can teach you how to use earthbending that I know myself.";
        if (a == 17) Man.ui.Info.text = "Try it right now!";
    }
    void Say2()
    {
        int a = Value2 + Value[2];
        //1
        if (a == 0) Man.ui.Info.text = "Oh, thank you, my dear friend! Now I can continue my research.";
        if (a == 1) Man.ui.Info.text = "By the way, I heard that an ancient civilization of Atlanteans once lived in these lands.";
        if (a == 2) Man.ui.Info.text = "They were masters of stone architecture and created incredible structures that still amaze with their beauty and grandeur.";
        if (a == 3) Man.ui.Info.text = "But unfortunately, all of that is in the past. I don't know what happened, but something destroyed that civilization and forced them to leave these lands.";
        if (a == 4) Man.ui.Info.text = "Maybe it was a flood, volcanic eruption, or something else... But I'm still exploring these lands, and who knows what else I'll discover? Ha-ha-ha-ha!";
        if (a == 5) Man.ui.Info.text = "Alright, traveler, be careful. There are unfriendly and incomprehensible creatures dwelling in these dark halls that don't like noise. Be quiet and cautious so as not to attract unnecessary attention.";
        //2
        if (a == 6) Man.ui.Info.text = "Oh, you're back! Yes, these are the tools I needed. You've been very helpful, my stone friend. Now I can return to my work.";
        if (a == 7) Man.ui.Info.text = "After seeing the stone people here, I began to wonder about what happened here in the past.";
        if (a == 8) Man.ui.Info.text = "I wasn't born here, but I've heard stories from the elder residents who talked about the past.";
        if (a == 9) Man.ui.Info.text = "Once, there was a civilization that was much more advanced than we are now. They created many magnificent technologies and buildings, but something went wrong.";
        if (a == 10) Man.ui.Info.text = "No one knows exactly what happened, but they all disappeared, and only their remains were left here. We live on the ruins of their former greatness.";
        if (a == 11) Man.ui.Info.text = "I'm here because my ancestors decided to settle this place, but they could never understand what happened to that civilization.";
        if (a == 12) Man.ui.Info.text = "I've been living here for many years and every day I think about what happened here and why they disappeared. I think it was something terrible and dangerous that we can't even imagine.";
        if (a == 13) Man.ui.Info.text = "Take your boots and good luck on your journey, wanderer!";
        //3
        if (a == 14) Man.ui.Info.text = "Thank you for helping me find my harp!";
        if (a == 15) Man.ui.Info.text = "I see you are very interested to know what this place is?";
        if (a == 16) Man.ui.Info.text = "You probably guessed that I am not from this civilization.";
        if (a == 17) Man.ui.Info.text = "But I know their history. Once, a very ancient civilization lived here, famous for its magical knowledge.";
        if (a == 18) Man.ui.Info.text = "They created many amazing inventions and achieved great success in science and art.";
        if (a == 19) Man.ui.Info.text = "But then a terrible incident occurred that destroyed them.";
        if (a == 17) Man.ui.Info.text = "No one knows exactly what happened, but it is said that there was a powerful cataclysm that destroyed civilization and left only ruins behind.";
        if (a == 18) Man.ui.Info.text = "That's the extent of my knowledge.";
        if (a == 19) Man.ui.Info.text = "Good luck, stone heart!";
    }
}
