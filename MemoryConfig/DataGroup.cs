using System;
using System.Collections.Generic;

namespace MemoryConfig
{

    public class DataGroup
    {

        public DataGroup(string name)
        {
            this.name = name;
            this.entries = new Dictionary<string, DataEntry>();
        }

        public string GetName()
        {
            return name;
        }

        public bool HasEntry(string name)
        {
            return entries.ContainsKey(name);
        }

        public DataGroup AddEntry(string name)
        {
            try
            {
                entries.Add(name, new DataEntry(name));
                return this;
            }
            catch
            {
                throw;
            }
        }

        public DataGroup AddEntry(string name, int value)
        {
            try
            {
                entries.Add(name, new DataEntry(name, value));
                return this;
            }
            catch
            {
                throw;
            }
        }

        public DataGroup AddEntry(string name, string value)
        {
            try
            {
                entries.Add(name, new DataEntry(name, value));
                return this;
            }
            catch
            {
                throw;
            }
        }

        public DataEntry GetEntry(string name)
        {
            try
            {
                return entries[name];
            }
            catch
            {
                return null;
            }
        }

        public bool RemoveEntry(string name)
        {
            return entries.Remove(name);
        }

        public bool IsEmpty
        {
            get
            {
                return (entries.Count == 0);
            }
        }

        public IEnumerable<DataEntry> Entries
        {
            get
            {
                foreach (var entry in entries) yield return entry.Value;
            }
        }

        private readonly string name;
        private Dictionary<string, DataEntry> entries;

    }

}
