using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExperienceGem : Pickup
{
    public int experienceGranted;

    public override void Collect()
    {
        if (hasBeenCollected) { return; }
        else { base.Collect(); }

        Debug.Log("Called");
        PlayerStats player = FindObjectOfType<PlayerStats>();
        player.IncreaseExperince(experienceGranted);
    }
}
