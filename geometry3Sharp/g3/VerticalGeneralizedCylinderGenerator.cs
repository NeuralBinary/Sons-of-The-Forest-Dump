using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	public class VerticalGeneralizedCylinderGenerator : MeshGenerator
	{
		// Token: 0x06001898 RID: 6296 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x1ED9190", Offset = "0x1ED7790", VA = "0x181ED9190", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x1EDA630", Offset = "0x1ED8C30", VA = "0x181EDA630")]
		public VerticalGeneralizedCylinderGenerator()
		{
		}

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x40")]
		public MeshGenerator.CircularSection[] Sections;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x48")]
		public int Slices;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x4C")]
		public bool Capped;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x4D")]
		public bool NoSharedVertices;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x50")]
		public int startCapCenterIndex;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x54")]
		public int endCapCenterIndex;
	}
}
