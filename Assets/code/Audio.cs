using UnityEngine;
public class Audio : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] AudioSource Muz;
    [SerializeField] AudioSource Sound;
    public void Volume(float a)
    {
        Muz.volume = a;
        Sound.volume = a;
    }
    public void PlayMuz(int a)
    {
        Muz.clip = Man.data.Muz[a];
        Muz.Play();
    }
    public void PlaySound(int a)
    {
        Sound.clip = Man.data.Sounds[a];
        Sound.Play();
    }
}
