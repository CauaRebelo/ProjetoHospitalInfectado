using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Info_Progresso
{
    private static int p_dia = 0;
    private static int p_dinheiro = 0;
    private static float p_pacienciaTimer = 300f;
    private static int p_score = 0;

    public static int dia
    {
        get { return p_dia; }
        set { p_dia = value; }
    }

    public static int dinheiro
    {
        get { return p_dinheiro; }
        set { p_dinheiro = value; }
    }

    public static int score
    {
        get { return p_score; }
        set { p_score = value; }
    }

    public static float pacienciaTimer
    {
        get { return p_pacienciaTimer; }
        set { p_pacienciaTimer = value; }
    }
}
