using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour            // �ؾ� �� ��: Init ���. 
{
    public static GameManager Instance;     // �̱��� ����
    // �Ŵ����� �� �޾ƿ���

    UIManager uiManager;

    public UIManager UIManager {  get { return uiManager; } }



    private void Awake()
    {
        Instance = this;
        uiManager = FindObjectOfType<UIManager>();
    }


    // ��ŸƮ������ ���ӸŴ����� �Ѿ�� �� �ְ� �ڵ� �ۼ��ؾ� �� �� �� ��ư ������ ���ξ����� ����.

    






    // ���� �÷��̾ ��뿡 ���� ��Ҵٸ� ��� ����
    private void EnterSaloon()
    {
        
    }






}
