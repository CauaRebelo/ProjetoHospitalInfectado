using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EscolhaDoencaBotao : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent<Doenca> OnChoiceDoenca { get; set; }

    public Doenca doenca;
    public void AdivinharDoenca()
    {
        doenca = this.gameObject.transform.GetComponent<BotaoDoencaComputador>().doenca;
        OnChoiceDoenca?.Invoke(doenca);
    }
}
