using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Lodding
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class CustomBillboardManager
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x30BD450", Offset = "0x30BBA50", VA = "0x1830BD450")]
		public static void Register(CustomBillboard customBillboard)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x30BD5F0", Offset = "0x30BBBF0", VA = "0x1830BD5F0")]
		public static void Unregister(CustomBillboard customBillboard)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x30BD710", Offset = "0x30BBD10", VA = "0x1830BD710")]
		private static void RemoveFromMask(LodSettingsTypeEnum eachType)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x30BD760", Offset = "0x30BBD60", VA = "0x1830BD760")]
		private static void AddToMask(LodSettingsTypeEnum eachType)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x30BD7B0", Offset = "0x30BBDB0", VA = "0x1830BD7B0")]
		private static void ClearInactiveMask()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x30BD800", Offset = "0x30BBE00", VA = "0x1830BD800")]
		private static void ClearNulls()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x30BD990", Offset = "0x30BBF90", VA = "0x1830BD990")]
		public static void SetBillboardMask(LodSettingsTypeEnum type, bool maskValue)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x30BDD80", Offset = "0x30BC380", VA = "0x1830BDD80")]
		public static void DebugSetBillboardTypeActive(LodSettingsTypeEnum billboardType, bool onSet)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x30BDDE0", Offset = "0x30BC3E0", VA = "0x1830BDDE0")]
		public static void SetQualityProfile(CustomBillboardManager.QualityProfile value)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x30BDFC0", Offset = "0x30BC5C0", VA = "0x1830BDFC0")]
		private static void SetSkipBuildCount(int skipBuildCount)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x30BE1E0", Offset = "0x30BC7E0", VA = "0x1830BE1E0")]
		private static void SetAllInActive()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x30BE540", Offset = "0x30BCB40", VA = "0x1830BE540")]
		private static void SetInactiveMask(List<LodSettingsTypeEnum> inactiveMask)
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<LodSettingsTypeEnum> InactiveTypes;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<CustomBillboard> CustomBillboards;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x10")]
		private static CustomBillboardManager.QualityProfile _activeProfile;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<LodSettingsTypeEnum> MediumQualityInactiveTypes;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x20")]
		private static int _highSkipBuildCount;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x24")]
		private static int _mediumSkipBuildCount;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x28")]
		private static int _lowSkipBuildCount;

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public enum QualityProfile
		{
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			High,
			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			Medium,
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			Low
		}
	}
}
