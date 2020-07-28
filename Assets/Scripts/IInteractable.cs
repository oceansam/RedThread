using UnityEngine;

namespace enemy
{
    public interface IInteractable{

        // {get;} is c# syntax for getters 
        float holdDuration { get; }
        bool holdInteractable { get; }
        bool multipleUse { get; }
        bool isInteractable { get; }
        float maxRange { get; }

        void OnStartHover();
        void OnInteract();
        void OnEndHover();
    }
}