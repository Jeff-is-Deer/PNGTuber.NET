﻿using System;
using Godot;
using static GlobalClass;

public partial class SensitivitySlider : HSlider
{
    public override void _Process(double delta)
    {
        Global.MicrophoneListener.VolumeSensitivity = MaxValue - Value;
    }
}
