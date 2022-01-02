using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_Loading : MonoBehaviour
{
    [SerializeField] private Image backGroundImg = null;
    [SerializeField] private Slider loadingBar = null;

    private void Start()
    {
        backGroundImg.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
    }

    private void Update()
    {
        if(SceneController.Instance().stageScene == null)
        {
            return;
        }
        if (loadingBar.value <= 0.9)
        {
            loadingBar.value = SceneController.Instance().stageScene.progress + 0.1f;
        }
            
    }



}
