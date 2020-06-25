using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    
    [SerializeField] LevelLoader levelLoader;

    void OnTriggerEnter2D(Collider2D col)
    {
        levelLoader.LoadPrevLevel();
    }

}
