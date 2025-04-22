using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    private 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoloGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DuoGame()
    {
        SceneManager.LoadScene(2);
    }
}
