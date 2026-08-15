using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;
using System.Text.Json;

namespace Lab06_RemoteControl.RDL;

internal static class RdlJsonParser
{
    public static RdlEnvelope Parse(string json)
    {
        using JsonDocument document = JsonDocument.Parse(json);

        JsonElement root = document.RootElement;

        string source = root.GetProperty("source").GetString()!;
        string destination = root.GetProperty("destination").GetString()!;
        string command = root.GetProperty("command").GetString()!;

        if (command == "SetPTT")
        {
            bool value = root.GetProperty("value").GetBoolean();

            return new RdlEnvelope(
                source,
                destination,
                new SetPTTCommand(value)
            );
        }

        throw new InvalidOperationException(
            $"Unknown command: {command}");
    }
}
