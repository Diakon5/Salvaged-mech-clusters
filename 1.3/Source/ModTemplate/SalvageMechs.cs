using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using UnityEngine;
using Verse;

namespace SMC
{
    [StaticConstructorOnStartup]
    public class SMC_CompProjectileInterceptor : ThingComp
    {
        public SMC_CompProperties_ProjectileInterceptor Props
        {
            get
            {
                return (SMC_CompProperties_ProjectileInterceptor)this.props;
            }
        }
    }
    public class SMC_CompProperties_ProjectileInterceptor : CompProperties
    {
        public SMC_CompProperties_ProjectileInterceptor()
        {
            this.compClass = typeof(SMC_CompProjectileInterceptor);

        }

        public float radius;

        public int disarmedByEmpForTicks;

        public bool interceptGroundProjectiles;

        public bool interceptAirProjectiles;

        public int chargeDurationTicks;

        public Color color = Color.white;

        public EffecterDef reactivateEffect;

        public EffecterDef interceptEffect;

        public SoundDef activeSound;
    }
}
