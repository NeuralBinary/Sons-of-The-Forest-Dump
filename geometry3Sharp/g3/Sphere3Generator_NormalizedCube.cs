using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class Sphere3Generator_NormalizedCube : GridBox3Generator
	{
		// Token: 0x060018DC RID: 6364 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x1EEA860", Offset = "0x1EE8E60", VA = "0x181EEA860", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x1EEAED0", Offset = "0x1EE94D0", VA = "0x181EEAED0")]
		public Sphere3Generator_NormalizedCube()
		{
		}

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0xC0")]
		public double Radius;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0xC8")]
		private Sphere3Generator_NormalizedCube.NormalizationTypes NormalizeType;

		// Token: 0x020002C4 RID: 708
		[Token(Token = "0x20002C4")]
		public enum NormalizationTypes
		{
			// Token: 0x04000C46 RID: 3142
			[Token(Token = "0x4000C46")]
			NormalizedVector,
			// Token: 0x04000C47 RID: 3143
			[Token(Token = "0x4000C47")]
			CubeMapping
		}
	}
}
