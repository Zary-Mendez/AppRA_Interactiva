using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string nombreEscenaMenu = "00_Menu";

    public void IrAlMenu()
    {
        SceneManager.LoadScene(nombreEscenaMenu);
    }
}