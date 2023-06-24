using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Animation;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	public static class IkUtils
	{
		// Token: 0x06001299 RID: 4761 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x2F3CA70", Offset = "0x2F3B070", VA = "0x182F3CA70")]
		public static void BeginHorizontalCutPromptIk(TargetInfo target)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x2F3D290", Offset = "0x2F3B890", VA = "0x182F3D290")]
		public static void BeginVerticalCutPromptIk(TargetInfo target, bool allowAimingAbove)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x2F3DE00", Offset = "0x2F3C400", VA = "0x182F3DE00")]
		public static void BeginHeldItemPromptIk(Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x2F3DEC0", Offset = "0x2F3C4C0", VA = "0x182F3DEC0")]
		public static void BeginHeldItemIk(float smoothDuration, Vector3 rightHandIkPos, Quaternion rotation, float ikWeight = 1f, bool bothHands = true, float delay = 0f)
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x2F3DF90", Offset = "0x2F3C590", VA = "0x182F3DF90")]
		public static void StopHeldItemIk()
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x2F3DFF0", Offset = "0x2F3C5F0", VA = "0x182F3DFF0")]
		public static void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x2F3E0D0", Offset = "0x2F3C6D0", VA = "0x182F3E0D0")]
		public static void BeginHeldRendererOnlyIK(Vector3 pos, Quaternion rot, Vector3 scale, IkSides sides, float delay, float smoothDuration, IkFilters filter = IkFilters.PosRotScale)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x2F3E1D0", Offset = "0x2F3C7D0", VA = "0x182F3E1D0")]
		public static void StopHeldRendererOnlyIK(IkSides sides, bool smooth = false)
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x2F3E240", Offset = "0x2F3C840", VA = "0x182F3E240")]
		public static void BeginHandIk(float smoothDuration, Vector3 handIkPos, Quaternion rotation, bool rightHand, bool maintainRotation, float ikWeight = 1f, float delay = 0f, [Optional] Transform relativeTo)
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x2F3E360", Offset = "0x2F3C960", VA = "0x182F3E360")]
		public static void StopHandsIk(bool rightHand = true, bool leftHand = true)
		{
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x2F3E3E0", Offset = "0x2F3C9E0", VA = "0x182F3E3E0")]
		public static void BeginAimIk(Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x2F3E480", Offset = "0x2F3CA80", VA = "0x182F3E480")]
		public static void BeginAimIk(float smoothDuration, Vector3 worldPos, IkAimModes aimModes = IkAimModes.Position, float delay = 0f)
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x2F3E530", Offset = "0x2F3CB30", VA = "0x182F3E530")]
		public static void BeginPlaceAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x2F3E530", Offset = "0x2F3CB30", VA = "0x182F3E530")]
		public static void BeginCutAimIk(TargetInfo target, IkAimModes aimModes = IkAimModes.Position)
		{
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x2DF6050", Offset = "0x2DF4650", VA = "0x182DF6050")]
		public static void StopAimIk()
		{
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0000B54C File Offset: 0x0000974C
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x2F3E5D0", Offset = "0x2F3CBD0", VA = "0x182F3E5D0")]
		private static Vector3 GetSizeFromTarget(TargetInfo target)
		{
			return default(Vector3);
		}
	}
}
