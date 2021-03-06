//
// Copyright 2013 Rami Tabbara
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
// Please see README.md to locate the external API documentation.
//
using System;
using Microsoft.Xna.Framework.Graphics;

namespace Cocos3D
{
    public static class LCC3TextureWrapModeExtension
    {
        internal static TextureAddressMode XnaTextureAddressMode(this LCC3TextureWrapMode textureWrapMode)
        {
            TextureAddressMode xnaTextureAddressMode = TextureAddressMode.Wrap;

            switch (textureWrapMode)
            {
                case LCC3TextureWrapMode.Wrap:
                    xnaTextureAddressMode = TextureAddressMode.Wrap;
                    break;
                case LCC3TextureWrapMode.Clamp:
                    xnaTextureAddressMode = TextureAddressMode.Clamp;
                    break;
                case LCC3TextureWrapMode.Mirror:
                    xnaTextureAddressMode = TextureAddressMode.Mirror;
                    break;
            }

            return xnaTextureAddressMode;
        }
    }
}

