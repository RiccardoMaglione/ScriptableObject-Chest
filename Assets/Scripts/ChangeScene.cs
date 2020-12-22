using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject PanelChest;
    public GameObject PanelInfo;

    public void ChestToInfo()
    {
        PanelChest.SetActive(false);
        PanelChest.SetActive(true);
    }

    public void InfoToChest()
    {
        PanelChest.SetActive(true);
        PanelChest.SetActive(false);
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
