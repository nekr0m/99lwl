using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    [SerializeField] SpriteRenderer Face;
    public int Pos;
    int Offset = 7;
    int Direction;
    void OnEnable()
    {
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            Direction = -1;
            Face.flipX = true;
        }
        if (a == 1)
        {
            Direction = 1;
            Face.flipX = false;
        }
        transform.position = new Vector3(Pos, 0, 0);
    }
    void Update()
    {
        transform.position += new Vector3(Direction * Time.deltaTime, 0, 0);
        if (Offset < transform.position.x)
        {
            Direction = -1;
            Face.flipX = true;
        }
        if (-Offset > transform.position.x)
        {
            Direction = 1;
            Face.flipX = false;
        }
    }
}
//public class EnemyMove : MonoBehaviour
//{
//    [SerializeField] Manadger Man;
//    [SerializeField] GameObject Left;
//    [SerializeField] GameObject Right;
//    [SerializeField] GameObject Snore;
//    [SerializeField] Image SnoreBar;
//    [SerializeField] SpriteRenderer Face;
//    public int Value;
//    public float Feal;
//    public bool Hounded;
//    int GGCatch = 10;
//    int Direction;
//    void Start()
//    {
//        int a = Random.Range(0, 2);
//        if (a == 0)
//        {
//            Direction = -1;
//            Face.flipX = true;
//            Left.SetActive(true);
//        }
//        if (a == 1)
//        {
//            Direction = 1;
//            Face.flipX = false;
//            Right.SetActive(true);
//        }
//    }
//    void Update()
//    {
//        if (Feal > 0)
//        {
//            Feal -= Time.deltaTime;
//            SnoreBar.fillAmount = Feal / GGCatch;
//            if (Feal <= 0) Snore.SetActive(false);
//            else Snore.SetActive(true);
//            if (Feal >= GGCatch) Man.data.Live = 0;
//        }
//        transform.position += new Vector3(Direction * Time.deltaTime, 0, 0);
//    }
//    void OnTriggerEnter2D(Collider2D body)
//    {
//        if (body.gameObject.tag == "Wall")
//        {
//            if (Direction == 1)
//            {
//                Direction = -1;
//                Face.flipX = true;
//                Left.SetActive(true);
//            }
//            else
//            {
//                Direction = 1;
//                Face.flipX = false;
//                Right.SetActive(true);
//            }
//        }
//    }
//}
