using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	public static class LocalPlayerAnimationUtils
	{
		// Token: 0x06003BE6 RID: 15334 RVA: 0x000116B8 File Offset: 0x0000F8B8
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x2F00C50", Offset = "0x2EFFC50", VA = "0x182F00C50")]
		public static Vector3 CalcGroundedPlayerPositionAtRange(Vector3 targetWorldPos, float rangeFromTarget, int layerMask)
		{
			return default(Vector3);
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x2F01060", Offset = "0x2F00060", VA = "0x182F01060")]
		public static Coroutine MovePlayerInRange(Vector3 targetWorldPos, float rangeFromTarget, float moveDuration, Action updateCallback, int groundLayerMask = 73400320)
		{
			return null;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x2F00F80", Offset = "0x2EFFF80", VA = "0x182F00F80")]
		public static Coroutine MovePlayerInRange(Vector3 targetMovePos, Vector3 targetLookAtPos, float rangeFromTarget, float moveDuration, Action updateCallback, int groundLayerMask = 73400320)
		{
			return null;
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x2F01170", Offset = "0x2F00170", VA = "0x182F01170")]
		public static Coroutine RotatePlayerTowards(Vector3 targetWorldPos, float smoothDuration, Action updateCallback)
		{
			return null;
		}

		// Token: 0x020008A9 RID: 2217
		[Token(Token = "0x20008A9")]
		private static class Constants
		{
			// Token: 0x04004002 RID: 16386
			[Token(Token = "0x4004002")]
			public const int GroundMask = 73400320;
		}
	}
}
