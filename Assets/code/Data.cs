using UnityEngine;
[CreateAssetMenu]
public class Data : ScriptableObject
{
    public AudioClip[] Muz;
    public AudioClip[] Sounds;
    public const float MaxEnergy = 10;
    public const float EnergyRegen = 1;
    public const int Speed = 4;
    public const int Jump = 5;
    public float ActiveSkill = 1; //1-0.5
    public int SkillUsed;
    public int Live = 1;
    public float Energy = 10;
    public float X;
    public float Y;

    public float Volume;

    public bool DeepSleep;
    public int SleepValue;

    public int Qvest;
    public int QvestCompleted; //-1/0/1

    public int Port;
    public int SavePort;

    public int Lwl;

    public bool NewLwl;

    public int Game;
}