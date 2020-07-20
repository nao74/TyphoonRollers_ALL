#region File Description
//-----------------------------------------------------------------------------
// FireParticleSystem.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace TyphoonRollers
{
    /// <summary>
    /// Custom particle system for creating a flame effect.
    /// </summary>
    class RotationParticleSystem : ParticleSystem
    {
        public RotationParticleSystem(Game1 game, ContentManager content)
            : base(game, content)
        { }


        protected override void InitializeSettings(ParticleSettings settings)
        {
            settings.TextureName = "ParticleTexture/RotationParticle";

            settings.MaxParticles = 5000;

            settings.Duration = TimeSpan.FromSeconds(2);

            settings.DurationRandomness = 1;

            settings.MinHorizontalVelocity = 5;
            settings.MaxHorizontalVelocity = 25;

            settings.MinVerticalVelocity = -15;
            settings.MaxVerticalVelocity = 20;

            // Set gravity upside down, so the flames will 'fall' upward.
            settings.Gravity = new Vector3(0, 15, 0);

            settings.MinColor = new Color(255, 255, 255, 10);
            settings.MaxColor = new Color(255, 255, 255, 40);

            settings.MinStartSize = 10;
            settings.MaxStartSize = 20;

            settings.MinEndSize = 25;
            settings.MaxEndSize = 40;

            // Use additive blending.
            settings.BlendState = BlendState.Additive;
        }
    }
}
