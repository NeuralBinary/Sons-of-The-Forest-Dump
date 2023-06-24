using System;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public struct DoublePoint
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xF9AB50", Offset = "0xF99150", VA = "0x180F9AB50")]
		public DoublePoint(double x = 0.0, double y = 0.0)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
		public DoublePoint(DoublePoint dp)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x28393B0", Offset = "0x28379B0", VA = "0x1828393B0")]
		public DoublePoint(IntPoint ip)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public double X;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public double Y;
	}
}
