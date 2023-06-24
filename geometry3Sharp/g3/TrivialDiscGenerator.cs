using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public class TrivialDiscGenerator : MeshGenerator
	{
		// Token: 0x0600189A RID: 6298 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x1EDA650", Offset = "0x1ED8C50", VA = "0x181EDA650", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x1EDAF40", Offset = "0x1ED9540", VA = "0x181EDAF40")]
		public TrivialDiscGenerator()
		{
		}

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x40")]
		public float Radius;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x44")]
		public float StartAngleDeg;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x48")]
		public float EndAngleDeg;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x4C")]
		public int Slices;
	}
}
