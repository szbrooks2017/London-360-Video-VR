using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkyBoxManager : MonoBehaviour
{
    public void BuildLevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }
}
