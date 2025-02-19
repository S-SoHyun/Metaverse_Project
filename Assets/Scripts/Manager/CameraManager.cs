using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    float offsetX;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            MainSceneCameraStart();
        }
        else
        {
            MiniGameCameraStart();
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            MainSceneCameraUpdate();
        }
        else
        {
            MiniGameCameraUpdate();
        }
    }


    // ���ξ� ��ŸƮ, ������Ʈ
    private void MainSceneCameraStart()
    {
        if (target == null) return;
    }


    private void MainSceneCameraUpdate()
    {
        Vector3 pos = transform.position;
        pos.x = target.position.x;
        pos.y = target.position.y;
        transform.position = pos;
    }



    // �̴ϰ��Ӿ� ��ŸƮ, ������Ʈ
    private void MiniGameCameraStart()
    {
        if (target == null) return;
        offsetX = transform.position.x - target.position.x;
    }

    private void MiniGameCameraUpdate()
    {

        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;

    }
}
