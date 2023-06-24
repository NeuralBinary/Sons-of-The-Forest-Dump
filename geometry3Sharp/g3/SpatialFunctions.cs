using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	public static class SpatialFunctions
	{
		// Token: 0x020003A9 RID: 937
		[Token(Token = "0x20003A9")]
		[Obsolete("NormalOffset is deprecated - is anybody using it? please lmk.")]
		public class NormalOffset
		{
			// Token: 0x06001E20 RID: 7712 RVA: 0x000151C4 File Offset: 0x000133C4
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x1F8D6A0", Offset = "0x1F8BCA0", VA = "0x181F8D6A0")]
			public Vector3d FindNearestAndOffset(Vector3d pos)
			{
				return default(Vector3d);
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x1F8D8A0", Offset = "0x1F8BEA0", VA = "0x181F8D8A0")]
			public NormalOffset()
			{
			}

			// Token: 0x0400106A RID: 4202
			[Token(Token = "0x400106A")]
			[FieldOffset(Offset = "0x10")]
			public DMesh3 Mesh;

			// Token: 0x0400106B RID: 4203
			[Token(Token = "0x400106B")]
			[FieldOffset(Offset = "0x18")]
			public ISpatial Spatial;

			// Token: 0x0400106C RID: 4204
			[Token(Token = "0x400106C")]
			[FieldOffset(Offset = "0x20")]
			public double Distance;

			// Token: 0x0400106D RID: 4205
			[Token(Token = "0x400106D")]
			[FieldOffset(Offset = "0x28")]
			public bool UseFaceNormal;
		}
	}
}
