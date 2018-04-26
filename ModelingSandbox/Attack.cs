using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingSandbox
{
    public class Attack
    {
        public int Damage;
        public List<DamageDistribution> DamageDistribution;
        public int range;
    }

    public enum DamageType
    {
        Slash,
        Pierce,
        Bludgeon
    }

    //For applying damage like: if you swing an axe thusly, 
    //  it does 50% slashing and 50% bludgeoning
    public class DamageDistribution
    {
        public int Weight;
        public DamageType DamageType;
    }
}
