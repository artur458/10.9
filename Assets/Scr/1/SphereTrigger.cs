using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    public TextMesh sphereCountText;
    private int sphereCount = 0;

    void Start()
    {
        sphereCountText.text = sphereCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        sphereCount++;
        sphereCountText.text = sphereCount.ToString();
    }

    private void OnTriggerExit(Collider other)
    {
        sphereCount--;
        sphereCountText.text = sphereCount.ToString();
    }
}
