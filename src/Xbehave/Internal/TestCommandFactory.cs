﻿// <copyright file="TestCommandFactory.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Internal
{
    using System.Collections.Generic;
    using System.Linq;
    using Xunit.Sdk;

    internal static class TestCommandFactory
    {
        public static IEnumerable<ITestCommand> Create(
            DisposableStep given, Step when, IEnumerable<Step> thens, IEnumerable<Step> thensInIsolation, IEnumerable<Step> thenSkips, IMethodInfo method)
        {
            var messages = new[] { (given == null ? null : given.Message), (when == null ? null : when.Message) }
                .Where(message => message != null).ToArray();

            var name = string.Join(" ", messages);

            var thenInIsolationExecutor = new ThenInIsolationExecutor(given, when, thensInIsolation);
            foreach (var command in thenInIsolationExecutor.Commands(name, method))
            {
                yield return command;
            }

            var thenExecutor = new ThenExecutor(given, when, thens);
            foreach (var command in thenExecutor.Commands(name, method))
            {
                yield return command;
            }

            foreach (var command in thenSkips
                .Select(step => new SkipCommand(method, name + ", " + step.Message, "Action is ThenSkip (instead of Then or ThenInIsolation)")))
            {
                yield return command;
            }
        }
    }
}