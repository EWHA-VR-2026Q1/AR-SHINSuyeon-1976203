using UnityEngine;

public interface IGeneral
{
    void OnEnter(GameObject sender);

    void OnStay(GameObject sender);

    void OnClick(GameObject sender);

    void OnExit(GameObject sender);
}