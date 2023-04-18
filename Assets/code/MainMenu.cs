using UnityEngine;
public class MainMenu : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] GameObject Continue;
    void Awake()
    {
        if (PlayerPrefs.HasKey("Game")) Man.data.Game = PlayerPrefs.GetInt("Game");
        if (Man.data.Game == 1) Continue.SetActive(true);
        else Man.save.FirstLoad();
    }
    public void NewGame()
    {
        Man.save.FirstLoad();
        Man.GoTo(1);
    }
}
