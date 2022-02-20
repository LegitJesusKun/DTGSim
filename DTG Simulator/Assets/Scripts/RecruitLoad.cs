using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecruitLoad : MonoBehaviour
{
    public void LoadScene(string RecruitScene)
    {
        SceneManager.LoadScene(RecruitScene);
    }
}
