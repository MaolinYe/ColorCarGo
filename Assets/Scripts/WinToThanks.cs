using UnityEngine;
using UnityEngine.SceneManagement;
public class WinToThanks : MonoBehaviour
{
    public void ToThanks()
    {
        SceneManager.LoadScene("ThanksScene");
    }
}
