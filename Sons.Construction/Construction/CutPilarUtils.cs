using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	public static class CutPilarUtils
	{
		// Token: 0x0600128A RID: 4746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x2F3B650", Offset = "0x2F39C50", VA = "0x182F3B650")]
		public static void CalcQuarters(TargetInfo targetInfo, Vector3 topExtremity, out int remainingQuarters, out int cutOffQuarters)
		{
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0000B51C File Offset: 0x0000971C
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x2F3B880", Offset = "0x2F39E80", VA = "0x182F3B880")]
		public static bool FindCutPosition(Vector3 targetPos, StructureElement target, Vector3 topExtremity, Vector3 groundExtremity, out Vector3 cutPosition, out int remainingQuarters)
		{
			return default(bool);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0000B534 File Offset: 0x00009734
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x2F3BDD0", Offset = "0x2F3A3D0", VA = "0x182F3BDD0")]
		public static float CalcAdjustedGroundPosition(float topHeight, float defaultLength)
		{
			return 0f;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x2F3BDE0", Offset = "0x2F3A3E0", VA = "0x182F3BDE0")]
		public static void SetCutHeight(Animator animator, float cutPositionY, float actorPositionY)
		{
		}
	}
}
