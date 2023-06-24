using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	internal class PrimalQuery2d
	{
		// Token: 0x06000FDC RID: 4060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public PrimalQuery2d(Func<int, Vector2d> PositionFunc)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0000BC9C File Offset: 0x00009E9C
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x1E3C960", Offset = "0x1E3AF60", VA = "0x181E3C960")]
		public int ToLine(int i, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0000BCB4 File Offset: 0x00009EB4
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x1E3C9E0", Offset = "0x1E3AFE0", VA = "0x181E3C9E0")]
		public int ToLine(Vector2d test, int v0, int v1)
		{
			return 0;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0000BCCC File Offset: 0x00009ECC
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x1E3CAC0", Offset = "0x1E3B0C0", VA = "0x181E3CAC0")]
		public int ToLine(int i, int v0, int v1, out int order)
		{
			return 0;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x1E3CC70", Offset = "0x1E3B270", VA = "0x181E3CC70")]
		public int ToLine(Vector2d test, int v0, int v1, out int order)
		{
			return 0;
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x1E3CDF0", Offset = "0x1E3B3F0", VA = "0x181E3CDF0")]
		public int ToTriangle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0000BD14 File Offset: 0x00009F14
		[Token(Token = "0x6000FE2")]
		[Address(RVA = "0x1E3CEF0", Offset = "0x1E3B4F0", VA = "0x181E3CEF0")]
		public int ToTriangle(Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0000BD2C File Offset: 0x00009F2C
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x1E3CFD0", Offset = "0x1E3B5D0", VA = "0x181E3CFD0")]
		public int ToTriangleUnsigned(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0000BD44 File Offset: 0x00009F44
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x1E3D050", Offset = "0x1E3B650", VA = "0x181E3D050")]
		public int ToTriangleUnsigned(Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0000BD5C File Offset: 0x00009F5C
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x1E3D140", Offset = "0x1E3B740", VA = "0x181E3D140")]
		public int ToCircumcircle(int i, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0000BD74 File Offset: 0x00009F74
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x1E3D1C0", Offset = "0x1E3B7C0", VA = "0x181E3D1C0")]
		public int ToCircumcircle(Vector2d test, int v0, int v1, int v2)
		{
			return 0;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0000BD8C File Offset: 0x00009F8C
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x1E3D3F0", Offset = "0x1E3B9F0", VA = "0x181E3D3F0")]
		public PrimalQuery2d.OrderType ToLineExtended(Vector2d P, Vector2d Q0, Vector2d Q1)
		{
			return PrimalQuery2d.OrderType.ORDER_Q0_EQUALS_Q1;
		}

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x10")]
		private Func<int, Vector2d> PointF;

		// Token: 0x020001ED RID: 493
		[Token(Token = "0x20001ED")]
		public enum OrderType
		{
			// Token: 0x040007FC RID: 2044
			[Token(Token = "0x40007FC")]
			ORDER_Q0_EQUALS_Q1,
			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			ORDER_P_EQUALS_Q0,
			// Token: 0x040007FE RID: 2046
			[Token(Token = "0x40007FE")]
			ORDER_P_EQUALS_Q1,
			// Token: 0x040007FF RID: 2047
			[Token(Token = "0x40007FF")]
			ORDER_POSITIVE,
			// Token: 0x04000800 RID: 2048
			[Token(Token = "0x4000800")]
			ORDER_NEGATIVE,
			// Token: 0x04000801 RID: 2049
			[Token(Token = "0x4000801")]
			ORDER_COLLINEAR_LEFT,
			// Token: 0x04000802 RID: 2050
			[Token(Token = "0x4000802")]
			ORDER_COLLINEAR_RIGHT,
			// Token: 0x04000803 RID: 2051
			[Token(Token = "0x4000803")]
			ORDER_COLLINEAR_CONTAIN
		}
	}
}
