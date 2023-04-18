using UnityEngine;
using UnityEngine.SceneManagement;
public class Manadger : MonoBehaviour
{
    public Data data;
    public SaveLoad save;
    public Move move;
    public Ui ui;
    public Audio aud;
    public Skill skill;
    public Qvest Qv;
    public Hint Hi;
    [SerializeField] GameObject Menu;
    void Awake()
    {
        Time.timeScale = 1;
        data.Live = 1;
        data.ActiveSkill = 1;
        data.SkillUsed = 0;
        data.Energy = 10;
        data.SleepValue = -1;
        save.Load();
        if (data.NewLwl)
        {
            data.QvestCompleted = -1;
            data.X = -7;
            data.Y = 0;
            data.Port = 0;
        }
        if (data.SavePort > 0 && SceneManager.GetActiveScene().buildIndex > 0)
        {
            move.Teleport(true);
            aud.PlayMuz(1);
        }
        aud.Volume(data.Volume);
        ui.Volume(data.Volume);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && data.Lwl > 0) 
        {
            if (Time.timeScale == 1) PauseGame(0);
            else PauseGame(1); 
        }
    }
    public void Winer()
    {
        data.Game = 0;
        PlayerPrefs.SetInt("Game", data.Game);
        PlayerPrefs.Save();
        GoTo(0);
    }
    public void Continue()
    {
        data.NewLwl = false;
        GoTo(data.Lwl);
    }
    public void GoTo(int a)
    {
        data.Lwl = a;
        if (data.Lwl > 0)
        {
            PlayerPrefs.SetInt("Lwl", data.Lwl);
            PlayerPrefs.Save();
        }
        SceneManager.LoadScene(data.Lwl);
    }
    public void PauseGame(int a)
    {
        Time.timeScale = a;
        if (a == 0) Menu.SetActive(true);
        else Menu.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
