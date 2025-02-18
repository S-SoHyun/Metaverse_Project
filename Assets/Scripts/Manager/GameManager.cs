using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour            // 해야 할 것: Init 고려. 
{
    public static GameManager Instance;     // 싱글톤 선언
    // 매니저들 다 받아오기


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }


    // 스타트씬에서 게임매니저로 넘어올 수 있게 코드 작성해야 할 듯 → 버튼 누르면 메인씬으로 오게.








    // 만약 플레이어가 살룸에 문에 닿았다면 살룸 입장
    private void EnterSaloon()
    {
        
    }






}
