using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class TriangulationUtil
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public TriangulationUtil()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x28AEEB0", Offset = "0x28AD4B0", VA = "0x1828AEEB0")]
		public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
		{
			return default(bool);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x28AEFF0", Offset = "0x28AD5F0", VA = "0x1828AEFF0")]
		public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd)
		{
			return default(bool);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x28AF0B0", Offset = "0x28AD6B0", VA = "0x1828AF0B0")]
		public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc)
		{
			return Orientation.CW;
		}

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x0")]
		public static double EPSILON;
	}
}
