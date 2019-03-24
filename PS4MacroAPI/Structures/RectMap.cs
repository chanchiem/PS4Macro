﻿// PS4MacroAPI (File: Structures/RectMap.cs)
//
// Copyright (c) 2018 Komefai
//
// Visit http://komefai.com for more information
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PS4MacroAPI
{
    /// <summary>
    /// Retangle template for matching
    /// </summary>
    public struct RectMap
    {
        /// <summary>
        /// Gets or sets the ID of this <see cref="RectMap"/>
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the x-coordinate of this <see cref="RectMap"/>
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the y-coordinate of this <see cref="RectMap"/>
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the width of this <see cref="RectMap"/>
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of this <see cref="RectMap"/>
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the hash of this <see cref="RectMap"/>
        /// </summary>
        public ulong Hash { get; set; }
    }
}
