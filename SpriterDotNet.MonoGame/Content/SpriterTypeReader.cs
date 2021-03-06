﻿// Copyright (C) The original author or authors
//
// This software may be modified and distributed under the terms
// of the zlib license.  See the LICENSE file for details.

using Microsoft.Xna.Framework.Content;

namespace SpriterDotNet.MonoGame.Content
{
    public class SpriterTypeReader : ContentTypeReader<Spriter>
    {
        public static SpriterReader Reader { get; set; }

        static SpriterTypeReader()
        {
            Reader = SpriterReader.Default;
        }

        protected override Spriter Read(ContentReader input, Spriter existingInstance)
        {
            string data = input.ReadString();
            return Reader.Read(data);
        }
    }
}
