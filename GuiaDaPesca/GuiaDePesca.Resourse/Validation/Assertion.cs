﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GuiaDePesca.Resourse.Validation
{
    public class Assertion
    {
        #region Contructors

        protected Assertion() { }

        #endregion

        #region Methods

        public static void Equals(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Length(string stringValue, int maximum, string message)
        {
            int length = stringValue.Trim().Length;
            if (length > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Length(string stringValue, int minimum, int maximum, string message)
        {
            if (String.IsNullOrEmpty(stringValue))
                stringValue = String.Empty;

            int length = stringValue.Trim().Length;
            if (length < minimum || length > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Matches(string pattern, string stringValue, string message)
        {
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(stringValue))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void NotEmpty(string stringValue, string message)
        {
            if (stringValue == null || stringValue.Trim().Length == 0)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void NotEmpty<T>(List<T> Value , string message)
        {
            if (Value == null || Value.Count == 0)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void NotEquals(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void NotNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Null(object object1, string message)
        {
            if (object1 != null)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Range(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Range(float value, float minimum, float maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Range(int value, int minimum, int maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void Range(long value, long minimum, long maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void True(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void False(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new InvalidOperationException(message);
            }
        }

        #endregion
    }
}
