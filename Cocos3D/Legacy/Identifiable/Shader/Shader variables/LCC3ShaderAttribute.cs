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

namespace Cocos3D
{
    public class LCC3ShaderAttribute : LCC3ShaderVariable
    {
        public static LCC3ShaderAttribute VariableInProgram(LCC3ShaderProgram program, LCC3VertexAttrIndex attrIndex)
        {
            return new LCC3ShaderAttribute(program, attrIndex);
        }

        #region Allocation and initialization

        public LCC3ShaderAttribute() : base()
        {
        }

        public LCC3ShaderAttribute(LCC3ShaderProgram program, LCC3VertexAttrIndex attrIndex) : base(program, (int)attrIndex)
        {
            switch (attrIndex)
            {
                case LCC3VertexAttrIndex.VertexAttribPosition:
                    this.Semantic = LCC3Semantic.SemanticVertexLocation;
                    break;
                case LCC3VertexAttrIndex.VertexAttribNormal:
                    this.Semantic = LCC3Semantic.SemanticVertexNormal;
                    break;
                case LCC3VertexAttrIndex.VertexAttribColor:
                    this.Semantic = LCC3Semantic.SemanticColor;
                    break;
                case LCC3VertexAttrIndex.VertexAttribTexCoords:
                    this.Semantic = LCC3Semantic.SemanticVertexTexture;
                    break;
            }

            this.Location = attrIndex;
        }

        public override void PopulateFromProgram()
        {
            _semantic = LCC3Semantic.SemanticNone;
        }

        #endregion Allocation and initialization
    }
}

