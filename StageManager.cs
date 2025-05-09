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
        Debug.Log("������ ����! �÷��̾ ���ظ� �Խ��ϴ�.");
        // �÷��̾� ü�� ���� ó�� ��
    }
}
