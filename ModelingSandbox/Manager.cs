using System;
using System.Collections.Generic;
using System.Text;

namespace ModelingSandbox
{
    public class Manager
    {
        public Area activeArea;
        public Dictionary<int, Person> actors;
        public Dictionary<int, Location> positions;

        public Manager()
        {
            InitCollections();
        }
        private void InitCollections()
        {
            actors = new Dictionary<int, Person>();
            positions = new Dictionary<int, Location>();
        }
        public ManagerMessage AddPerson(ref Person person, Location location)
        {
            ManagerMessage response = new ManagerMessage();

            int personId = actors.Count;
            person.Id = personId;
            person.Manager = this;
            actors.Add(personId, person);
            positions.Add(personId, location);

            response.Code = personId;
            response.Message = $"{person} added at location {location}";

            return response;
        }

        internal bool CheckLineOfSight(int id1, int id2)
        {
            throw new NotImplementedException();
        }

        public ManagerMessage MovePerson(int personId, Location newPosition)
        {
            ManagerMessage response = new ManagerMessage();
            Location oldPosition = positions[personId];
            Person person = actors[personId];
            int moveDistance = Location.GetDistance(oldPosition, newPosition);
            if ( moveDistance <= person.MoveRange)
            {
                positions[personId] = newPosition;
                response.Success = true;
                response.Message = $"Moved {person} from {oldPosition} to {newPosition}";
            }
            else
            {
                response.Success = false;
                response.Message = $"Move range for {person} exceeded. (Moving from {oldPosition} to {newPosition}.  Calculated Range: {moveDistance})";
            }

            return response;
        }
    }

    public class ManagerMessage
    {
        public int Code;
        public string Message;
        public bool Success;

        public ManagerMessage()
        {
            Success = true;
            Code = 0;
            Message = "";
        }
    }
}
