using UnityEngine;
[CreateAssetMenu]
public class SaveLoad : ScriptableObject
{
    [SerializeField] Data data;
    public void Save()
    {
        data.SavePort = data.Port;
        PlayerPrefs.SetInt("Game", data.Game);
        PlayerPrefs.SetInt("Lwl", data.Lwl);
        PlayerPrefs.SetInt("SavePort", data.SavePort);
        PlayerPrefs.SetInt("Qvest", data.Qvest);
        PlayerPrefs.SetInt("QvestCompleted", data.QvestCompleted);
        PlayerPrefs.SetFloat("X", data.X);
        PlayerPrefs.SetFloat("Y", data.Y);

        PlayerPrefs.Save();
    }
    public void Load()
    {
        data.Game = PlayerPrefs.GetInt("Game");
        data.Lwl = PlayerPrefs.GetInt("Lwl");
        data.SavePort = PlayerPrefs.GetInt("SavePort");
        data.Qvest = PlayerPrefs.GetInt("Qvest");
        data.QvestCompleted = PlayerPrefs.GetInt("QvestCompleted");
        data.X = PlayerPrefs.GetFloat("X");
        data.Y = PlayerPrefs.GetFloat("Y");
        data.Port = data.SavePort;
    }
    public void FirstLoad()
    {
        data.Game = 1;
        data.NewLwl = true;
        data.Volume = 0.5f;
        Save();
    }
}