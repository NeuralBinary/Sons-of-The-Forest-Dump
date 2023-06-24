using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	public static class PhysicsUtilities
	{
		// Token: 0x06000333 RID: 819 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA9B9A0", Offset = "0xA99FA0", VA = "0x180A9B9A0")]
		public static Vector3 CalculateForwardFromRayHitNormal(Transform transformSource, LayerMask collisionMask, Vector3 rayDirection, float rayStartOffset, float maxRayDistance)
		{
			return default(Vector3);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA9BB20", Offset = "0xA9A120", VA = "0x180A9BB20")]
		public static bool CalculateForwardFromRayHitNormal(Vector3 rayStart, Vector3 rayDirection, LayerMask collisionMask, float rayStartOffset, float maxRayDistance, Vector3 transformRight, out Vector3 result)
		{
			return default(bool);
		}
	}
}
