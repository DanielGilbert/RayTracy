using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RayTracy.Components
{
    public class Camera
    {
        private int _imageWidth;
        private int _imageHeight;
        private float _aspectRatio;
        private float _viewPortHeight;
        private float _viewPortWidth;

        private Vector3 _horizontalVector3;
        private Vector3 _verticalVector3;
        private Vector3 _lowerLeftCorner;

        public Vector3 Position { get; }
        public float FocalLength { get; }

        public Vector3 LowerLeftCorner => _lowerLeftCorner;
        public Vector3 HorizontalVector3 => _horizontalVector3;
        public Vector3 VerticalVector3 => _verticalVector3;

        public Camera(Vector3 position, float focalLength, int imageWidth, int imageHeight)
        {
            _imageWidth = imageWidth;
            _imageHeight = imageHeight;

            _aspectRatio = (float)imageWidth / (float)imageHeight;

            _viewPortHeight = 2.0f;
            _viewPortWidth = _aspectRatio * _viewPortHeight;

            _horizontalVector3 = new(_viewPortWidth, 0f, 0f);
            _verticalVector3 = new(0f, _viewPortHeight, 0f);
            _lowerLeftCorner = position - _horizontalVector3 / 2.0f - _verticalVector3 / 2.0f - new Vector3(0f, 0f, focalLength);

            Position = position;
            FocalLength = focalLength;
        }
    }
}