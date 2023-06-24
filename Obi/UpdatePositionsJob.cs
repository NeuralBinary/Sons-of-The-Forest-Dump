using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[BurstCompile]
	internal struct UpdatePositionsJob : IJobParallelFor
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x27AA440", Offset = "0x27A8A40", VA = "0x1827AA440", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> positions;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float4> previousPositions;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> velocities;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientations;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public NativeArray<quaternion> previousOrientations;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x60")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> angularVelocities;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x70")]
		[ReadOnly]
		public float velocityScale;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x74")]
		[ReadOnly]
		public float sleepThreshold;
	}
}
