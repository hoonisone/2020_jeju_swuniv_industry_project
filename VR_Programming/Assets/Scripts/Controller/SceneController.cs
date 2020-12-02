﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneController : MonoBehaviour
{
    public static string stageName;

    // 게임 화면으로 이동
    public void callGame()
    {
        stageName = EventSystem.current.currentSelectedGameObject.name;
        SceneManager.LoadScene("GameScene");
    }

    public void callMainScene() { SceneManager.LoadScene("MainScene"); }    // 첫 화면으로 이동
    public void callSelectStage() { SceneManager.LoadScene("StageScene"); }    // 스테이지 선택 화면으로 이동
    public void callhowtoScene() { SceneManager.LoadScene("howtoScene"); }      // 게임 방법 화면으로 이동
}