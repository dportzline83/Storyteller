﻿using System;
using System.Collections.Generic;
using FubuCore;
using StoryTeller.Results;

namespace StoryTeller.Messages
{
    [Serializable]
    public class QueueState : ClientMessage, IBatchedMessage
    {
        public QueueState() : base("queue-state")
        {
        }

        public string[] queued = new string[0];
        public string running = null;

        public IEnumerable<string> AllSpecIds()
        {
            if (running.IsNotEmpty()) yield return running;

            if (queued != null)
            {
                foreach (var id in queued)
                {
                    yield return id;
                }
            }
        }
    }
}