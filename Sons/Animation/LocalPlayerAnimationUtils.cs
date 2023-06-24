using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x0200091A RID: 2330
	[Token(Token = "0x200091A")]
	public static class LocalPlayerAnimationUtils
	{
		// Token: 0x06004317 RID: 17175 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x6004317")]
		[Address(RVA = "0x363EF80", Offset = "0x363D580", VA = "0x18363EF80")]
		public static Vector3 CalcGroundedPlayerPositionAtRange(Vector3 targetWorldPos, float rangeFromTarget, int layerMask)
		{
			return default(Vector3);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004318")]
		[Address(RVA = "0x363F3E0", Offset = "0x363D9E0", VA = "0x18363F3E0")]
		public static Coroutine MovePlayerInRange(Vector3 targetWorldPos, float rangeFromTarget, float moveDuration, Action updateCallback, int groundLayerMask = 73400320)
		{
			return null;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x363F590", Offset = "0x363DB90", VA = "0x18363F590")]
		public static Coroutine MovePlayerInRange(Vector3 targetMovePos, Vector3 targetLookAtPos, float rangeFromTarget, float moveDuration, Action updateCallback, int groundLayerMask = 73400320)
		{
			return null;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x363F760", Offset = "0x363DD60", VA = "0x18363F760")]
		public static Coroutine RotatePlayerTowards(Vector3 targetWorldPos, float smoothDuration, Action updateCallback)
		{
			return null;
		}

		// Token: 0x0200091B RID: 2331
		[Token(Token = "0x200091B")]
		private static class Constants
		{
			// Token: 0x0400462E RID: 17966
			[Token(Token = "0x400462E")]
			public const int GroundMask = 73400320;
		}
	}
}
