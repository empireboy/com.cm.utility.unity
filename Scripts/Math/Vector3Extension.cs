using UnityEngine;

namespace CM.Math
{
	public static class Vector3Extension
	{
		public static Vector3 AngularPosition(this Vector3 position, float angleY, float angleZ, float radius)
		{
			Vector3 angularPosition = position + Quaternion.Euler(0, angleY, angleZ) * Vector3.right * radius;

			return angularPosition;
		}
	}
}
