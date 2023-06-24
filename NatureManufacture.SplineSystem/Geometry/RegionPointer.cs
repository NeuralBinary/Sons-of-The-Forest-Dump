using System;
using Il2CppDummyDll;

namespace TriangleNet.Geometry
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class RegionPointer
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B0")]
		public double Area
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x24EAC90", Offset = "0x24E9290", VA = "0x1824EAC90")]
			set
			{
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x24EAD00", Offset = "0x24E9300", VA = "0x1824EAD00")]
		public RegionPointer(double x, double y, int id)
		{
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x24EAD20", Offset = "0x24E9320", VA = "0x1824EAD20")]
		public RegionPointer(double x, double y, int id, double area)
		{
		}

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x10")]
		internal Point point;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x18")]
		internal int id;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x20")]
		internal double area;
	}
}
