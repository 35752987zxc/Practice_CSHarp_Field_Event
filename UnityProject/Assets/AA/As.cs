using UnityEngine;

public class As : MonoBehaviour
{  //小雞
    [Header("雞"), Range(0, 999)]
    public int ru = 999;
    [Header("速度"),Range(0.1f,10f)]
    public float rul = 10f;
    [Tooltip("111")]
    public string k = "111";
    public bool a = true;

    private void Start()
    {
        print("哈哈");
    }
    private void Update()
    {
        print("咕咕");
    }
}
