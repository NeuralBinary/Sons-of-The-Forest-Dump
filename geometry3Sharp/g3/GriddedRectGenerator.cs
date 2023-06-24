using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class GriddedRectGenerator : TrivialRectGenerator
	{
		// Token: 0x060018CF RID: 6351 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x1EE4780", Offset = "0x1EE2D80", VA = "0x181EE4780", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D0")]
		[Address(RVA = "0x1EE5250", Offset = "0x1EE3850", VA = "0x181EE5250")]
		public GriddedRectGenerator()
		{
		}

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x60")]
		public int EdgeVertices;
	}
}
