using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour            // �ؾ� �� ��: Init ���. 
{
    public static GameManager Instance;     // �̱��� ����
    // �Ŵ����� �� �޾ƿ���


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }


    // ��ŸƮ������ ���ӸŴ����� �Ѿ�� �� �ְ� �ڵ� �ۼ��ؾ� �� �� �� ��ư ������ ���ξ����� ����.








    // ���� �÷��̾ ��뿡 ���� ��Ҵٸ� ��� ����
    private void EnterSaloon()
    {
        
    }






}
