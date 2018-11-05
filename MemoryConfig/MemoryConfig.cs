using System;
using System.Collections.Generic;

namespace MemoryConfig
{

    public partial class MemoryConfig
    {

        public MemoryConfig()
        {
            this.groups = new Dictionary<string, DataGroup>();
        }

        public static MemoryConfig LoadFromFile(string filePath)
        {
            MemoryConfig config = new MemoryConfig();

            try
            {
                FileHandler.DeserializeConfig(config, filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                config = null;
            }

            return config;
        }

        public bool SaveToFile(string filePath)
        {
            bool success = true;

            try
            {
                FileHandler.SerializeConfig(this, filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                success = false;
            }

            return success;
        }

        public bool HasGroup(string name)
        {
            return groups.ContainsKey(name);
        }

        public MemoryConfig AddGroup(string name)
        {
            try
            {
                groups.Add(name, new DataGroup(name));
                return this;
            }
            catch
            {
                throw;
            }
        }

        public DataGroup GetGroup(string name)
        {
            try
            {
                return groups[name];
            }
            catch
            {
                return null;
            }
        }

        public bool RemoveGroup(string name)
        {
            return groups.Remove(name);
        }

        public bool IsEmpty
        {
            get
            {
                return (groups.Count == 0);
            }
        }

        public IEnumerable<DataGroup> Groups
        {
            get
            {
                foreach (var group in groups) yield return group.Value;
            }
        }

        private Dictionary<string, DataGroup> groups;

    }

}
