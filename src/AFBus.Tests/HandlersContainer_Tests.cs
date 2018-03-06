﻿using System;
using AFBus;
using AFBus.Tests.TestClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AFBus.Tests
{
    [TestClass]
    public class HandlersContainer_Tests
    {

        [TestMethod]
        public void FunctionContainer_IFunctionTypesAreCorrectlyScanned()
        {
            var container = new HandlersContainer();

            Assert.IsTrue(container.messageHandlersDictionary[typeof(TestMessage)].Count == 2);

        }

        [TestMethod]
        public void FunctionContainer_IFunctionTypesAreCorrectlyInvoked()
        {
            var container = new HandlersContainer();

            Assert.IsTrue(container.messageHandlersDictionary[typeof(TestMessage)].Count == 2);

            container.InvokeAsync(new TestMessage(), null);

            Assert.IsTrue(InvocationCounter.Instance.Counter == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Handler not found for this message.")]
        public void FunctionContainer_HandlerNotFoundForThisMessage()
        {
            var container = new HandlersContainer();

            Assert.IsTrue(container.messageHandlersDictionary[typeof(TestMessage)].Count == 2);

            container.InvokeAsync(new TestMessageHandler2(), null);
            
        }

        

    }
}