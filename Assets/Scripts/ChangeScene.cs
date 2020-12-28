using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MaglioneFramework
{
    public class ChangeScene : MonoBehaviour
    {
        public GameObject PanelChest;
        public GameObject PanelInfo;

        public void ChestToInfo()
        {
            PanelChest.SetActive(false);
            PanelInfo.SetActive(true);
        }

        public void InfoToChest()
        {
            PanelChest.SetActive(true);
            PanelInfo.SetActive(false);
        }

        public void ReloadScene()
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}