using UnityEngine;
public class PartDeth : MonoBehaviour
{
    float Timer = 1;
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0) Destroy(gameObject);
    }
}
