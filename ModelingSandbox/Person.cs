using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingSandbox
{
    public class Person : Actor
    {
        public string Name;
        public int MoveRange = 1;

        //Reference to a given actor's manager.  Move to Actor class?
        public Manager Manager;

        //For tracking who, on the board, is known by a given person
        List<int> PerceivedActors;

        //For tracking atacks that are currently available, based on active equipment, skills, etc...
        List<Attack> ReadyAttacks;

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
