// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class QueryRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GetEvents))
            {
                writer.WritePropertyName("getEvents"u8);
                writer.WriteObjectValue(GetEvents);
            }
            if (Optional.IsDefined(GetSeries))
            {
                writer.WritePropertyName("getSeries"u8);
                writer.WriteObjectValue(GetSeries);
            }
            if (Optional.IsDefined(AggregateSeries))
            {
                writer.WritePropertyName("aggregateSeries"u8);
                writer.WriteObjectValue(AggregateSeries);
            }
            writer.WriteEndObject();
        }
    }
}
