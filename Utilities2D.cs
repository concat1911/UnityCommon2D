// author: Tran Nhat Linh - nhatlinh.nh2511@gmail.com
// No copyright, free for use

using UnityEngine;

namespace VeryDisco.Common2D
{
    public static class Utilities2D
    {
        /// <summary>
        /// Calculates and returns the orthographic bounds of the given camera.
        /// The bounds are calculated based on the camera's orthographic size and aspect ratio.
        /// </summary>
        /// <param name="camera">The camera for which to calculate the orthographic bounds.</param>
        /// <returns>The calculated orthographic bounds of the camera.</returns>
        public static Bounds GetCameraOrthographicBounds(this Camera camera)
        {
            float orthographicSize = camera.orthographicSize;
            float aspectRatio = camera.aspect;

            float cameraWidth = orthographicSize * 2 * aspectRatio;
            float cameraHeight = orthographicSize * 2;

            Vector3 cameraPosition = camera.transform.position;

            Bounds bounds = new Bounds(cameraPosition, new Vector3(cameraWidth, cameraHeight, 0));

            return bounds;
        }
    }
}
