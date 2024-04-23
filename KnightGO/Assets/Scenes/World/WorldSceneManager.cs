using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSceneManager : KGSceneManager
{
    private GameObject knightro;
    private AsyncOperation loadScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void playerTapped(GameObject player)
    {

    }

    public override void knightTapped(GameObject knight)
    {
        List<GameObject> list = new List<GameObject>();
        list.Add(knightro);
        SceneTransitionManager.Instance.GoToScene(KGConstants.SCENE_CAPTURE, list);
    }
}
