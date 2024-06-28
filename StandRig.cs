using GorillaShirts.Tools;
using System;
using UnityEngine;

namespace GorillaShirts.Models
{
    public class StandRig : Rig
    {
        public event Action<Configuration.PreviewTypes> OnAppearanceChange;

        public Color
            SteadyColour = new(0.9f, 0.9f, 0.9f),
            SillyColour = new(0.9f, 0.9f, 0.0f);

        public MeshRenderer
            SteadyHat, SillyHat;

        public void SetAppearance(bool isSilly)
        {
            SteadyHat.enabled = !isSilly;
            SillyHat.enabled = isSilly;
            RigSkin.material.color = isSilly ? SillyColour : SteadyColour;
            Nametag.text = isSilly ? "YELLOW" : "WHITE";

            OnAppearanceChange?.Invoke(isSilly ? Configuration.PreviewTypes.Silly : Configuration.PreviewTypes.Steady);
        }
    }
}
