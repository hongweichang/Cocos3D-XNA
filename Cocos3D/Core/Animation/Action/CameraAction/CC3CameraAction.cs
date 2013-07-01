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
    public abstract class CC3CameraAction : CC3TranslationAction
    {
        // Instance fields

        private CC3Vector _cameraTargetTranslationChange;
        private CC3Quaternion _cameraRotationChangeRelativeToCameraTarget;
        private float  _cameraNearClippingDistanceChange;
        private float _cameraFarClippingDistanceChange;

        #region Properties

        // Instance properties

        public CC3Vector CameraTargetTranslationChange
        {
            get { return _cameraTargetTranslationChange; }
        }

        public float CameraNearClippingDistanceChange
        {
            get { return _cameraNearClippingDistanceChange; }
        }

        public float CameraFarClippingDistanceChange
        {
            get { return _cameraFarClippingDistanceChange; }
        }

        #endregion Properties


        #region Constructors

        public CC3CameraAction(CC3Vector cameraTranslationChange, 
                               CC3Vector cameraTargetTranslationChange,
                               CC3Quaternion cameraRotationChangeRelativeToCameraTarget,
                               float cameraNearClippingDistanceChange,
                               float cameraFarClippingDistanceChange) 
            : base(cameraTranslationChange)
        {
            _cameraTargetTranslationChange = cameraTargetTranslationChange;
            _cameraRotationChangeRelativeToCameraTarget = cameraRotationChangeRelativeToCameraTarget;
            _cameraNearClippingDistanceChange = cameraNearClippingDistanceChange;
            _cameraFarClippingDistanceChange = cameraFarClippingDistanceChange;
        }

        #endregion Constructors


        #region Getting target transform changes for a subinterval of time

        internal CC3Vector IncrementalCameraTargetTranslationChange(float timeElapsedFraction, float timeIncrementFraction)
        {
            return _cameraTargetTranslationChange * timeIncrementFraction;
        }

        internal CC3Quaternion IncrementalCameraRotationChangeRelativeToCameraTarget(float timeElapsedFraction, float timeIncrementFraction)
        {
            return CC3Quaternion.CC3QuaternionSlerp(CC3Quaternion.CC3QuaternionIdentity, _cameraRotationChangeRelativeToCameraTarget, timeIncrementFraction);
        }

        #endregion Getting transform changes for a subinterval of time
               
    }
}

