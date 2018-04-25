using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingSandbox
{
    public class Person : Actor
    {
        public string Name;
        public int Atk = 1;
        public int MoveRange = 1;

        public Manager Manager;
        List<int> PerceivedActors;

        public Person()
        {
            HP = 10;
            Def = 1;
        }

        public void Aggro(Actor target)
        {
            //If I don't know location, roll perception
            if (!PerceivedActors.Contains(target.Id))
            {
                //Roll perception
            }
            //If I don't have line of sight, work around obstruction
            if (!Manager.CheckLineOfSight(Id, target.Id))
            {

            }
            //If I'm not in range, move closer
            //Attack
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
