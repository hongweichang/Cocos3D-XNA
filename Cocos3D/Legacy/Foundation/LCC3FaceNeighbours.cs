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
    public struct LCC3FaceNeighbours
    {
        // ivars

        uint _neighbourIndex1;
        uint _neighbourIndex2;
        uint _neighbourIndex3;


        #region Properties

        public uint NeighbourIndex1
        {
            get { return _neighbourIndex1; }
        }

        public uint NeighbourIndex2
        {
            get { return _neighbourIndex2; }
        }

        public uint NeighbourIndex3
        {
            get { return _neighbourIndex3; }
        }

        #endregion Properties


        #region Constructors

        public LCC3FaceNeighbours(uint nIndex1, uint nIndex2, uint nIndex3)
        {
            _neighbourIndex1 = nIndex1;
            _neighbourIndex2 = nIndex2;
            _neighbourIndex3 = nIndex3;
        }

        #endregion Constructors
    }
}

