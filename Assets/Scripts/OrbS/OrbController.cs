using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{
    [SerializeField] private List<DragAndDrop> orbs = new List<DragAndDrop>();

    public void ChangeMoving(bool enable)
    {
        foreach (var dragAndDrop in orbs)
        {
            dragAndDrop.moveEnabled = enable;
            if (enable)
            {
                dragAndDrop.StartCoroutine(dragAndDrop.IEMoveOrb());
            }
            else
            {
                dragAndDrop.StopCoroutine(dragAndDrop.IEMoveOrb());
            }
        }
    }
}
