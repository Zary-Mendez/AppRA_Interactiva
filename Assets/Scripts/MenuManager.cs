using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    [SerializeField] private string nombreEscenaMenu = "00_Menu";

    public void IrAlMenu()
    {
        SceneManager.LoadScene(nombreEscenaMenu);
    }
}