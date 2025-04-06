using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDePause1 : MonoBehaviour
{
    public GameObject painel_do_menu;

    // Start is called before the first frame update
    void Start()
    {
        painel_do_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            PausarJogo();
        }
    }



    private void PausarJogo()
    {
        // estiver funcionando -> pause
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            painel_do_menu.SetActive(true);
        }

        // pausado -. funcione
        else if (Time.timeScale == 0) 
        {
            Time.timeScale = 1;
            painel_do_menu.SetActive(false);
        }

        
    }
}
