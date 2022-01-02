using UnityEngine;

public class PortalController : MonoBehaviour
{

    private StageController stageCtrl = null;

    private void Start()
    {
        stageCtrl = gameObject.AddComponent<StageController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            float sceneNum = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
            if (sceneNum == 1)
            {
                stageCtrl.SetStage(GameManager.stageNum);

            }
            else if (sceneNum == 2)
            {
                ++GameManager.stageNum;
                stageCtrl.SetStage(GameManager.stageNum);
            }
        }
    }
}