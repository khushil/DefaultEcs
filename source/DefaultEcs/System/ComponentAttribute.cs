﻿using System;

namespace DefaultEcs.System
{
    /// <summary>
    /// Specifies which filter rule should be applied when using a <see cref="ComponentAttribute"/>.
    /// </summary>
    public enum ComponentFilterType
    {
        /// <summary>
        /// Given component types should be present.
        /// </summary>
        With,

        /// <summary>
        /// Given component type should be absent.
        /// </summary>
        Without,

        /// <summary>
        /// At least one of the given component types should be present.
        /// </summary>
        WithAny,
    }

    /// <summary>
    /// Represents the base attribute to declare how to build the inner <see cref="EntitySet"/> of <see cref="AEntitySystem{T}"/> when giving a <see cref="World"/> instance.
    /// Do not use this attribute, prefer <see cref="WithAttribute"/> and <see cref="WithoutAttribute"/> instead.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ComponentAttribute : Attribute
    {
        /// <summary>
        /// The types of the component.
        /// </summary>
        public readonly Type[] ComponentTypes;

        /// <summary>
        /// Whether the component type should be included or excluded.
        /// </summary>
        public readonly ComponentFilterType FilterType;

        /// <summary>
        /// Initialize a new instance of the <see cref="ComponentAttribute"/> type.
        /// </summary>
        /// <param name="filterType">The type of filter to apply with the given types.</param>
        /// <param name="componentTypes">The types of the component.</param>
        public ComponentAttribute(ComponentFilterType filterType, params Type[] componentTypes)
        {
            ComponentTypes = componentTypes ?? throw new ArgumentNullException(nameof(componentTypes));
            FilterType = filterType;
        }
    }

    /// <summary>
    /// Represents a component type to include when building the inner <see cref="EntitySet"/> of <see cref="AEntitySystem{T}"/> when giving a <see cref="World"/> instance.
    /// </summary>
    public sealed class WithAttribute : ComponentAttribute
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="WithAttribute"/> type.
        /// </summary>
        /// <param name="componentTypes">The types of the component to include.</param>
        public WithAttribute(params Type[] componentTypes)
            : base(ComponentFilterType.With, componentTypes)
        { }
    }

    /// <summary>
    /// Represents a component type to exclude when building the inner <see cref="EntitySet"/> of <see cref="AEntitySystem{T}"/> when giving a <see cref="World"/> instance.
    /// </summary>
    public sealed class WithoutAttribute : ComponentAttribute
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="WithoutAttribute"/> type.
        /// </summary>
        /// <param name="componentTypes">The types of the component to exclude.</param>
        public WithoutAttribute(params Type[] componentTypes)
            : base(ComponentFilterType.Without, componentTypes)
        { }
    }

    /// <summary>
    /// Represents a group of component types to include when building the inner <see cref="EntitySet"/> of <see cref="AEntitySystem{T}"/> when giving a <see cref="World"/> instance.
    /// </summary>
    public sealed class WithAnyAttribute : ComponentAttribute
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="WithAnyAttribute"/> type.
        /// </summary>
        /// <param name="componentTypes">The types of the component to include.</param>
        public WithAnyAttribute(params Type[] componentTypes)
            : base(ComponentFilterType.WithAny, componentTypes)
        { }
    }
}