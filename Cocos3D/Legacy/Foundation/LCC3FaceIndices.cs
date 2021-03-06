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
    public struct LCC3FaceIndices
    {
        // static vars

        static readonly LCC3FaceIndices _CC3FaceIndicesZero = new LCC3FaceIndices(0,0,0);

        // ivars

        uint _index1;
        uint _index2;
        uint _index3;

        #region Properties

        // Static properties

        public static LCC3FaceIndices CC3FaceIndicesZero
        {
            get { return _CC3FaceIndicesZero; }
        }

        // Instance properties

        public uint Index1
        {
            get { return _index1; }
        }

        public uint Index2
        {
            get { return _index2; }
        }

        public uint Index3
        {
            get { return _index3; }
        }

        #endregion Properties

      
        #region Constructors

        public LCC3FaceIndices(uint index1, uint index2, uint index3)
        {
            _index1 = index1;
            _index2 = index2;
            _index3 = index3;
        }

        public LCC3FaceIndices(LCC3FaceIndices faceIndices, uint offset1, uint offset2, uint offset3)
        : this(faceIndices.Index1 + offset1, faceIndices.Index2 + offset2, faceIndices.Index3 + offset3)
        {

        }

        public LCC3FaceIndices(LCC3FaceIndices faceIndices, uint offset)
        : this(faceIndices, offset, offset, offset)
        {

        }


        #endregion Constructors
    }
}

