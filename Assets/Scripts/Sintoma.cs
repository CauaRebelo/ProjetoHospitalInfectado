using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LetterBoxer;

[CreateAssetMenu]
public class Sintoma : ScriptableObject
{
    public enum Tipo { Visual, RaioX, Dialogo, Reacao };

    [Tooltip("Nome do sintoma.")]
    public string nome = "PlaceHolder";
    [Tooltip("Tipo do sintoma, sintomas visuais mudam a aparencia, raio x aparecem no exame de raio x, dialogo mudam o dialogo e reação faz o paciente ter reação a algo.")]
    public Tipo tipo;
    [Tooltip("Breve descrição do Sintoma")]
    public string descricao = "Esse sintoma acontece quando um paciente não existe, esse texto não deveria estar aparecendo para você, ladrão.";
}
