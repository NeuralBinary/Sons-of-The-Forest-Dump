using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[BurstCompile]
	internal struct UpdatePrincipalAxisJob : IJobParallelFor
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x27AA660", Offset = "0x27A8C60", VA = "0x1827AA660", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<quaternion> renderableOrientations;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<int> phases;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<float4> principalRadii;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> principalAxis;
	}
}
