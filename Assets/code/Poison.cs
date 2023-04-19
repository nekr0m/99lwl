using UnityEngine;
public class Poison : MonoBehaviour
{
    [SerializeField] Manadger Man;
    float a;
    void OnEnable()
    {
        a = 0.1f;
    }
    void Update()
    {
        if (a > 0)
        {
            a -= Time.deltaTime;
            if (a <= 0) Man.aud.PlayMuz(2);
        }
    }
    void OnDisable()
    {
        Man.aud.PlayMuz(0);
    }
}
