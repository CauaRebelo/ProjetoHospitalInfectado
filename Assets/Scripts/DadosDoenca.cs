using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DadosDoenca : MonoBehaviour
{
    Doenca doenca;
    [field: SerializeField]
    public UnityEvent<string> OnGiveTitulo { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveTransmissao { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveLetalidade { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveSintoma1 { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveSintoma2 { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveSintoma3 { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveDescricao { get; set; }
    [field: SerializeField]
    public UnityEvent<string> OnGiveNivel { get; set; }
    public void ReceberDoenca()
    {
        doenca = this.gameObject.transform.GetComponent<BotaoDoencaComputador>().doenca;
        Debug.Log(doenca.name);
        OnGiveTitulo?.Invoke(doenca.name);
        OnGiveDescricao?.Invoke(doenca.descricao);
        OnGiveSintoma1?.Invoke(doenca.sintomas[0].nome);
        OnGiveSintoma2?.Invoke(doenca.sintomas[1].nome);
        OnGiveSintoma3?.Invoke(doenca.sintomas[2].nome);
        OnGiveTransmissao?.Invoke(doenca.transmissao.ToString());
        OnGiveLetalidade?.Invoke(doenca.letalidade.ToString());
        OnGiveNivel?.Invoke(doenca.dificuldade.ToString());
    }
}
