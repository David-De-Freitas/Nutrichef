﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playlist_BuildScene : MonoBehaviour
{
    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        GameManager.Instance.Audio.Playlist_AddMusic(sceneName, "Autumn Day");
    }
}
