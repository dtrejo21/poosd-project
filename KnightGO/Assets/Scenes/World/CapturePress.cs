using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CapturePress : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPress()
    {
        SceneTransitionManager.Instance.GoToScene(KGConstants.SCENE_CAPTURE, new List<GameObject>());
    }
}
