using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	public static class MovementUtilities
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x0000635C File Offset: 0x0000455C
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x70ACE0", Offset = "0x7092E0", VA = "0x18070ACE0")]
		public static Vector2 ClampVelocity(Vector2 velocity, float maxSpeed, float slowdownFactor, bool slowWhenNotFacingTarget, Vector2 forward)
		{
			return default(Vector2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00006374 File Offset: 0x00004574
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x70AF50", Offset = "0x709550", VA = "0x18070AF50")]
		public static Vector2 CalculateAccelerationToReachPoint(Vector2 deltaPosition, Vector2 targetVelocity, Vector2 currentVelocity, float forwardsAcceleration, float rotationSpeed, float maxSpeed, Vector2 forwardsVector)
		{
			return default(Vector2);
		}
	}
}
