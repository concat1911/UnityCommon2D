namespace VeryDisco.Common2D
{
    using UnityEngine;

    /// <summary>
    /// Credit to BrownBot
    /// Source: https://discussions.unity.com/t/scaling-my-background-sprite-to-fill-screen-2d/93264
    /// </summary>
    public class SpriteScaleFitScreen : MonoBehaviour
    {
        private void Awake()
        {
            Resize();
        }

        public void Resize()
        {
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr == null) return;

            var camera = Camera.main;

            // Line up sprite with camera
            transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, transform.position.z);

            // Get viewport sizes
            float worldScreenHeight = camera.orthographicSize * 2f;
            float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

            // Scale sprite
            var spriteSize = sr.sprite.bounds.size;
            Vector3 scale = Vector3.one;
            scale.x = worldScreenWidth / spriteSize.x;
            scale.y = worldScreenHeight / spriteSize.y;

            transform.localScale = scale;
        }
    }
}
