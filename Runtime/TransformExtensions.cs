using UnityEngine;

namespace Letete.Utils.Runtime
{
	public static class TransformExtensions
	{
		public static void SetXPosition(this Transform transform, float newX)
        {
			transform.position = new Vector3
				(
					newX,
					transform.position.y,
					transform.position.z
				);
        }

		public static void SetYPosition(this Transform transform, float newY)
        {
			transform.position = new Vector3
				(
					transform.position.x,
					newY,
					transform.position.z
				);
        }

		public static void SetZPosition(this Transform transform, float newZ)
        {
			transform.position = new Vector3
				(
					transform.position.x,
					transform.position.y,
					newZ
				);
        }

		public static void SetXScale(this Transform transform, float newX)
        {
			transform.localScale = new Vector3
				(
					newX,
					transform.localScale.y,
					transform.localScale.z
				);
        }

		public static void SetYScale(this Transform transform, float newY)
		{
			transform.localScale = new Vector3
				(
					transform.localScale.x,
					newY,
					transform.localScale.z
				);
		}

		public static void SetZScale(this Transform transform, float newZ)
		{
			transform.localScale = new Vector3
				(
					transform.localScale.x,
					transform.localScale.y,
					newZ
				);
		}
	}
}