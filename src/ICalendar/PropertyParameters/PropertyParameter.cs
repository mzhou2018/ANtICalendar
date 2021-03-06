﻿using ICalendar.GeneralInterfaces;

namespace ICalendar.PropertyParameters
{
    public class PropertyParameter : IPropertyParameter
    {
        public PropertyParameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; set; }
    }
}