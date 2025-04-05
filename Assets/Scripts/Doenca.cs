using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Doenca : ScriptableObject
{
    public enum Transmissao { NaoTransmissivel, Sanguinia, Fluidos, Respiratoria, Pensamento, Catastofre};
    public enum Letalidade { Inofensiva, PequenoRiscoMorte, Letal, AltamenteLetal, MorteInstanea, Apocalipse, MortoVivo};

    [Tooltip("Nome da Doença.")]
    public string nome = "PlaceHolder";
    [Tooltip("A maneira que a doença é transmitida.")]
    public Transmissao transmissao;
    [Tooltip("O qual mortal é a doença.")]
    public Letalidade letalidade;
    [Tooltip("Define quais sintomas a doença vai ter. Para pegar sintomas, puxe-os da pasta Sintomas dentro da Pasta Doencas.")]
    public List<Sintoma> sintomas = new List<Sintoma>();
    [Tooltip("Define em qual dia a doença vai começar a aparecer.")]
    public int dificuldade = 0;
    [Tooltip("Breve descrição da Doença.")]
    public string descricao = "Esse doença acontece quando um paciente não existe, esse texto não deveria estar aparecendo para você, ladrão.";
}
