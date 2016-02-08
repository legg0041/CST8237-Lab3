using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSceneWithName(string sceneName)
    {
        // loads the scene specified by the button click
        SceneManager.LoadScene(sceneName);
    }

}
