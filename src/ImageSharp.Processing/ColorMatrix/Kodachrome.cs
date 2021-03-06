﻿// <copyright file="Kodachrome.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp
{
    using System;

    using Processing;
    using Processing.Processors;

    /// <summary>
    /// Extension methods for the <see cref="Image{TColor}"/> type.
    /// </summary>
    public static partial class ImageExtensions
    {
        /// <summary>
        /// Alters the colors of the image recreating an old Kodachrome camera effect.
        /// </summary>
        /// <typeparam name="TColor">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <returns>The <see cref="Image{TColor}"/>.</returns>
        public static Image<TColor> Kodachrome<TColor>(this Image<TColor> source)
            where TColor : struct, IPixel<TColor>
        {
            return Kodachrome(source, source.Bounds);
        }

        /// <summary>
        /// Alters the colors of the image recreating an old Kodachrome camera effect.
        /// </summary>
        /// <typeparam name="TColor">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TColor}"/>.</returns>
        public static Image<TColor> Kodachrome<TColor>(this Image<TColor> source, Rectangle rectangle)
            where TColor : struct, IPixel<TColor>
        {
            source.ApplyProcessor(new KodachromeProcessor<TColor>(), rectangle);
            return source;
        }
    }
}
