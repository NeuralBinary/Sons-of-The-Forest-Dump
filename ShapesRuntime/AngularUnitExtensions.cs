using System;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public static class AngularUnitExtensions
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x2A47420", Offset = "0x2A45A20", VA = "0x182A47420")]
		public static string Suffix(this AngularUnit unit)
		{
			return null;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x2A47490", Offset = "0x2A45A90", VA = "0x182A47490")]
		public static string Name(this AngularUnit unit)
		{
			return null;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000BBB")]
		[Address(RVA = "0x2A47500", Offset = "0x2A45B00", VA = "0x182A47500")]
		public static string NameShort(this AngularUnit unit)
		{
			return null;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x2A47570", Offset = "0x2A45B70", VA = "0x182A47570")]
		public static float FromRadians(this AngularUnit unit)
		{
			return 0f;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x2A47670", Offset = "0x2A45C70", VA = "0x182A47670")]
		public static float ToRadians(this AngularUnit unit)
		{
			return 0f;
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		public static string[] angUnitToSuffix;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x8")]
		public static string[] angUnitNames;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x10")]
		public static string[] angUnitNamesShort;
	}
}
