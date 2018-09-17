using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }
        
        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            if(_roster.ContainsKey(wave))
            {
                _roster[wave].Add(cadet);
            }
            else
            {
                _roster.Add(wave,new List<string>());
                _roster[wave].Add(cadet);
                
            }

        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            List<string> list = new List<string>();
            if(_roster.ContainsKey(wave))
            {
                 list = _roster[wave];

                list.Sort();

                return list;
            }
            else{
                    return list;
            }
            
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            SortedDictionary<int, List<String>> dict = new SortedDictionary<int, List<string>>(_roster);
         //  var dict=new SortedDictionary<int,List<string>>(_roster);

            foreach (var item in dict)
            {
                item.Value.Sort();
                cadets.AddRange(item.Value);
            }

            return cadets;
        }
    }
}
