﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AFBus
{
    /// <summary>
    /// Stores the information of the saga taken through reflection.
    /// </summary>
    class SagaInfo
    {

        public Type SagaType { get; set; }

        public List<MessageToMethod> CommandsThatAreCorrelatedByTheSaga { get; set; }

        public List<MessageToMethod> CommandsThatActivateTheSaga { get; set; }       

        public List<MessageToMethod> EventsThatCorrelatesSagas { get; set; }
    }

    class MessageToMethod
    {
        public Type Message { get; set; }

        public MethodInfo HandlingMethod { get; set; }

        public MethodInfo CorrelatingMethod { get; set; }

    }
}
