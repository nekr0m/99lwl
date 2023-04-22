using UnityEngine;
public class Door : MonoBehaviour
{
    [SerializeField] Manadger Man;
    [SerializeField] int Value;
    void Update()
    {
        if (Man.data.QvestCompleted >= Value) gameObject.SetActive(false);
    }
}
