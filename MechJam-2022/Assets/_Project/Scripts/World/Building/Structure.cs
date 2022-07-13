﻿using UnityEngine;

namespace Gisha.MechJam.World.Building
{
    public class Structure : MonoBehaviour
    {
        [SerializeField] private StructureData structureData;

        public Cell[] takenArea;

        protected virtual void Start()
        {
            if (takenArea == null)
                takenArea = WorldManager.Grid.GetCellsArea(transform.position,
                    structureData.GetDimensions(WorldManager.Grid.CellSize), 0f);

            for (int i = 0; i < takenArea.Length; i++)
            {
                if (takenArea[i] == null)
                    continue;
                
                takenArea[i].isBlockedByStructure = true;
            }
        }
    }
}