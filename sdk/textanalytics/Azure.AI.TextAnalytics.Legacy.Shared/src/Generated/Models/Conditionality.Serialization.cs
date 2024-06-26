// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal static partial class ConditionalityExtensions
    {
        public static string ToSerialString(this Conditionality value) => value switch
        {
            Conditionality.Hypothetical => "hypothetical",
            Conditionality.Conditional => "conditional",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Conditionality value.")
        };

        public static Conditionality ToConditionality(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "hypothetical")) return Conditionality.Hypothetical;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "conditional")) return Conditionality.Conditional;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown Conditionality value.");
        }
    }
}
