using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Doenca : ScriptableObject
{
    public enum Transmissao { NaoTransmissivel, Sanguinia, Fluidos, Respiratoria, Pensamento, Catastofre};
    public enum Letalidade { Inofensiva, PequenoRiscoMorte, Letal, AltamenteLetal, MorteInstanea, Apocalipse, MortoVivo};

    [Tooltip("Nome da Doen�a.")]
    public string nome = "PlaceHolder";
    [Tooltip("A maneira que a doen�a � transmitida.")]
    public Transmissao transmissao;
    [Tooltip("O qual mortal � a doen�a.")]
    public Letalidade letalidade;
    [Tooltip("Define quais sintomas a doen�a vai ter. Para pegar sintomas, puxe-os da pasta Sintomas dentro da Pasta Doencas.")]
    public List<Sintoma> sintomas = new List<Sintoma>();
    [Tooltip("Define em qual dia a doen�a vai come�ar a aparecer.")]
    public int dificuldade = 0;
    [Tooltip("Breve descri��o da Doen�a.")]
    public string descricao = "Esse doen�a acontece quando um paciente n�o existe, esse texto n�o deveria estar aparecendo para voc�, ladr�o.";
}
