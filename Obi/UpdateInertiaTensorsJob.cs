using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[BurstCompile]
	internal struct UpdateInertiaTensorsJob : IJobParallelFor
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x27A9DD0", Offset = "0x27A83D0", VA = "0x1827A9DD0", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float> inverseMasses;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float> inverseRotationalMasses;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<float4> principalRadii;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> inverseInertiaTensors;
	}
}
