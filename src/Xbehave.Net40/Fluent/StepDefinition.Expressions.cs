﻿// <copyright file="StepDefinition.Expressions.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Fluent
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    internal partial class StepDefinition : IStepDefinition
    {
        public IStepDefinition When(Expression<Action> body)
        {
            return _.When(body);
        }

        public IStepDefinition When(Expression<Func<IDisposable>> body)
        {
            return _.When(body);
        }

        public IStepDefinition When(Expression<Func<System.Collections.Generic.IEnumerable<IDisposable>>> body)
        {
            return _.When(body);
        }

        public IStepDefinition When(Expression<Action> body, Action dispose)
        {
            return _.When(body, dispose);
        }

        public IStepDefinition Then(Expression<Action> body)
        {
            return _.Then(body);
        }

        public IStepDefinition ThenInIsolation(Expression<Action> body)
        {
            return _.ThenInIsolation(body);
        }

        public IStepDefinition ThenSkip(Expression<Action> body, string reason)
        {
            return _.ThenSkip(body, reason);
        }

        public IStepDefinition And(Expression<Action> body)
        {
            return _.And(body);
        }

        public IStepDefinition And(Expression<Func<IDisposable>> body)
        {
            return _.And(body);
        }

        public IStepDefinition And(Expression<Func<IEnumerable<IDisposable>>> body)
        {
            return _.And(body);
        }

        public IStepDefinition And(Expression<Action> body, Action dispose)
        {
            return _.And(body, dispose);
        }

        public IStepDefinition AndInIsolation(Expression<Action> body)
        {
            return _.AndInIsolation(body);
        }

        public IStepDefinition AndSkip(Expression<Action> body, string reason)
        {
            return _.AndSkip(body, reason);
        }

        public IStepDefinition But(Expression<Action> body)
        {
            return _.But(body);
        }

        public IStepDefinition ButInIsolation(Expression<Action> body)
        {
            return _.ButInIsolation(body);
        }

        public IStepDefinition ButSkip(Expression<Action> body, string reason)
        {
            return _.ButSkip(body, reason);
        }
    }
}