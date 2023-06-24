using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[BurstCompile]
	internal struct UpdateNormalsJob : IJob
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x27A9F40", Offset = "0x27A8540", VA = "0x1827A9F40", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> deformableTriangles;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float4> renderPositions;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<float4> normals;
	}
}
