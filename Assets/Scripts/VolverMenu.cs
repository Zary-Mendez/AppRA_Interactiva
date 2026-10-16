using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverMenu : MonoBehaviour
{
    public void AbrirImageTarget()
    {
        SceneManager.LoadScene("01_ImageTargets");
    }

    public void AbrirGroundPlane()
    {
        SceneManager.LoadScene("02_GroundPlane");
    }

    public void AbrirMidAir()
    {
        SceneManager.LoadScene("03_MidAir");
    }

    public void IrAlMenu()
    {
        SceneManager.LoadScene("00_Menu");
    }
}