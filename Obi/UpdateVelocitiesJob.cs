using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[BurstCompile]
	internal struct UpdateVelocitiesJob : IJobParallelFor
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x27AA780", Offset = "0x27A8D80", VA = "0x1827AA780", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float> inverseMasses;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float4> previousPositions;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> positions;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x40")]
		[WriteOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> velocities;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public NativeArray<float> inverseRotationalMasses;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public NativeArray<quaternion> previousOrientations;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x70")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientations;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x80")]
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<float4> angularVelocities;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		public float deltaTime;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x94")]
		[ReadOnly]
		public bool is2D;
	}
}
