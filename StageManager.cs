using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ReachFinish(Monster monster)
    {
        Debug.Log("목적지 도착! 플레이어가 피해를 입습니다.");
        // 플레이어 체력 감소 처리 등
    }
}
