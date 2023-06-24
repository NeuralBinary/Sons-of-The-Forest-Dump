using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Areas
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class AreaMaskExtensions
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2D26630", Offset = "0x2D24C30", VA = "0x182D26630")]
		public static bool Matches(this AreaMask filter, AreaMask value)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2D26650", Offset = "0x2D24C50", VA = "0x182D26650")]
		public static bool IsCaveOrBunkerArea(this AreaMask value)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2D26660", Offset = "0x2D24C60", VA = "0x182D26660")]
		public static bool IsCaveArea(this AreaMask value)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2D26670", Offset = "0x2D24C70", VA = "0x182D26670")]
		public static bool IsBunkerArea(this AreaMask value)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2D26680", Offset = "0x2D24C80", VA = "0x182D26680")]
		public static bool IsRaftArea(this AreaMask value)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2D26690", Offset = "0x2D24C90", VA = "0x182D26690")]
		public static List<string> ToStringList(this AreaMask filter)
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x634E80", Offset = "0x633480", VA = "0x180634E80")]
		public static AreaMask OnValidate(this AreaMask filter)
		{
			return AreaMask.None;
		}
	}
}
