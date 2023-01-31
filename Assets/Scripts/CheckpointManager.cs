using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Checkpoint[] checkpoints;

    private void Start()
    {
        checkpoints = GetComponentsInChildren<Checkpoint>();
     
    }

    public Checkpoint GetLastPassedCheckpointThatWasPassed()
    {
        return checkpoints.Last(t => t.Passed);
    }

}
