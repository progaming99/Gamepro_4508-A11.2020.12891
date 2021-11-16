using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnPlay()
        {
            SceneManager.LoadScene ("Main");
        }
        public void Credits()
        {
            SceneManager.LoadScene ("Credits");
        }
        public void Help()
        {
            SceneManager.LoadScene ("Help");
        }
        public void OnMenu()
        {
            SceneManager.LoadScene ("Menu");
        }
}
