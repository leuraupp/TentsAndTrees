using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core.Singleton;

public class GameManager : Singleton<GameManager>

{
    private void Start() {
        
    }

    public void SelectedLevel(int level) {
        if (level == 1) {
            SceneManager.LoadScene("level 1");
            LoadGrid(level);
        }
    }

    public void LoadGrid(int level) {
        if (level == 1) {

        }
    }
}
