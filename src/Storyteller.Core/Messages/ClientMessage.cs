﻿using Newtonsoft.Json;

namespace Storyteller.Core.Messages
{
    public abstract class ClientMessage
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        protected ClientMessage(string type)
        {
            Type = type;
        }
    }
}