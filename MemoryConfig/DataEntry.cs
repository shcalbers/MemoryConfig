using System;

namespace MemoryConfig
{

    public class DataEntry
    {

        public DataEntry(string name)
        {
            this.name = name;
            this.value = null;
        }

        public DataEntry(string name, int value)
        {
            this.name = name;
            this.value = value;
        }

        public DataEntry(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string GetName()
        {
            return name;
        }

        public Type GetValueType()
        {
            return value.GetType();
        }

        public ValueType GetValue<ValueType>()
        {
            return (ValueType)value;
        }

        public void SetValue(int newValue)
        {
            value = newValue;
        }

        public void SetValue(string newValue)
        {
            value = newValue;
        }

        public bool IsEmpty
        {
            get { return (value == null); }
        }

        private readonly string name;
        private object value;

    }

}
