using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	[AddComponentMenu("Sons/Construction/StakeStructure")]
	public class StakeStructure : Structure
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		[Token(Token = "0x170003F5")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001137")]
			[Address(RVA = "0xE51990", Offset = "0xE4FF90", VA = "0x180E51990", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F6")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6001138")]
			[Address(RVA = "0x2F203F0", Offset = "0x2F1E9F0", VA = "0x182F203F0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F7")]
		public static Counter Counter
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x2F20440", Offset = "0x2F1EA40", VA = "0x182F20440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x2F20490", Offset = "0x2F1EA90", VA = "0x182F20490", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x2F204B0", Offset = "0x2F1EAB0", VA = "0x182F204B0", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x2F204C0", Offset = "0x2F1EAC0", VA = "0x182F204C0")]
		private void CastSupportedTarpsToGround()
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0000A8BC File Offset: 0x00008ABC
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x2F20800", Offset = "0x2F1EE00", VA = "0x182F20800", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x2F20AD0", Offset = "0x2F1F0D0", VA = "0x182F20AD0", Slot = "77")]
		public override Quaternion CalcElementRotation(StructureElement elementPrefab, int elementIndex)
		{
			return default(Quaternion);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x2F20BD0", Offset = "0x2F1F1D0", VA = "0x182F20BD0")]
		public StakeStructure()
		{
		}

		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x02000238 RID: 568
		[Token(Token = "0x2000238")]
		public static class Utils
		{
			// Token: 0x06001141 RID: 4417 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001141")]
			[Address(RVA = "0x2F20DB0", Offset = "0x2F1F3B0", VA = "0x182F20DB0")]
			internal static void CalcStakeSnapPosFromTarp(TarpDirections targetTarpDir, TarpStructure targetTarp, out Vector3 snapPos)
			{
			}

			// Token: 0x06001142 RID: 4418 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001142")]
			[Address(RVA = "0x2F21410", Offset = "0x2F1FA10", VA = "0x182F21410")]
			internal static void GetStakeDirectionForTarp(StakeStructure targetStake, TarpStructure targetTarp, out Directions dirA)
			{
			}

			// Token: 0x06001143 RID: 4419 RVA: 0x0000A8EC File Offset: 0x00008AEC
			[Token(Token = "0x6001143")]
			[Address(RVA = "0x2F216D0", Offset = "0x2F1FCD0", VA = "0x182F216D0")]
			internal static TarpDirections CalcStakeTarpDirFromTarp(TarpStructure targetTarp, Vector3 hitPoint)
			{
				return TarpDirections.BackBeam;
			}
		}
	}
}
