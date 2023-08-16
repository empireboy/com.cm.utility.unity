using UnityEngine;

namespace CM.Math
{
	public static class Vector2Extension
	{
		public static Vector2 AngularPosition(this Vector3 position, float angle, float radius)
		{
			Vector2 angularPosition = (Vector2)position + (Vector2)(Quaternion.Euler(0, 0, angle) * Vector2.right) * radius;

			return angularPosition;
		}
	}
}
