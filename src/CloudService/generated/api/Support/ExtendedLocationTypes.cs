// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support
{

    /// <summary>
    /// The supported ExtendedLocation types. Currently only EdgeZone is supported in Microsoft.Network resources.
    /// </summary>
    public partial struct ExtendedLocationTypes :
        System.IEquatable<ExtendedLocationTypes>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes EdgeZone = @"EdgeZone";

        /// <summary>the value for an instance of the <see cref="ExtendedLocationTypes" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ExtendedLocationTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExtendedLocationTypes" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ExtendedLocationTypes(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ExtendedLocationTypes</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ExtendedLocationTypes (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ExtendedLocationTypes && Equals((ExtendedLocationTypes)obj);
        }

        /// <summary>Creates an instance of the <see cref="ExtendedLocationTypes" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ExtendedLocationTypes(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum ExtendedLocationTypes</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ExtendedLocationTypes</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ExtendedLocationTypes</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ExtendedLocationTypes" />.</param>

        public static implicit operator ExtendedLocationTypes(string value)
        {
            return new ExtendedLocationTypes(value);
        }

        /// <summary>Implicit operator to convert ExtendedLocationTypes to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ExtendedLocationTypes" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ExtendedLocationTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ExtendedLocationTypes</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e1, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ExtendedLocationTypes e2)
        {
            return e2.Equals(e1);
        }
    }
}