using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    // Attach this script to the button

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        // This function will be called when the button is clicked
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
