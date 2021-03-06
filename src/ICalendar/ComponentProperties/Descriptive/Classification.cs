﻿namespace ICalendar.ComponentProperties
{
    /// <summary>
    /// Purpose: This property defines the access classification for a
    ///calendar component.
    /// Conformance: The property can be specified once in a "VEVENT",
    ///"VTODO", or "VJOURNAL" calendar components.
    /// </summary>
    public class Classification : ComponentProperty<ClassificationValues.ClassificationValue>
    {
        public override string Name => "CLASSIFICATION";
    }

    /// <summary>
    /// Define the possible values that a CLASSIFICATION property may have.
    /// Define some useful methods to convert from and to string the values.
    /// </summary>
    public class ClassificationValues
    {
        public enum ClassificationValue
        {
            PUBLIC, PRIVATE, CONFIDENTIAL
        }

        /// <summary>
        /// Convert to string the value
        /// </summary>
        /// <returns></returns>
        public static string ToString(ClassificationValue value)
        {
            switch (value)
            {
                case ClassificationValue.CONFIDENTIAL:
                    return "CONFIDENTIAL";

                case ClassificationValue.PRIVATE:
                    return "PRIVATE";

                case ClassificationValue.PUBLIC:
                    return "PUBLIC";

                default:
                    return "PUBLIC";
            }
        }

        /// <summary>
        /// return a Value enum from the given string
        /// If the value is not recognised the return the
        /// default PUBLC
        /// </summary>
        /// <param name="str">The string representation of the Value</param>
        /// <returns>The equivalent of the string representation</returns>
        public static ClassificationValue ConvertValue(string str)
        {
            switch (str)
            {
                case "CONFIDENTIAL":
                    return ClassificationValue.CONFIDENTIAL;

                case "PRIVATE":
                    return ClassificationValue.PRIVATE;

                case "PUBLC":
                    return ClassificationValue.PUBLIC;

                default:
                    return ClassificationValue.PUBLIC;
            }
        }
    }
}