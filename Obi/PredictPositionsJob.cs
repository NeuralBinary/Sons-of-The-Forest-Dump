using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DB RID: 219
	[Token(Token = "0x20000DB")]
	[BurstCompile]
	internal struct PredictPositionsJob : IJobParallelFor
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x27A99D0", Offset = "0x27A7FD0", VA = "0x1827A99D0", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<int> phases;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float> buoyancies;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<float4> externalForces;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public NativeArray<float> inverseMasses;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> previousPositions;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x60")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> positions;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x70")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> velocities;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x80")]
		[ReadOnly]
		public NativeArray<float4> externalTorques;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		public NativeArray<float> inverseRotationalMasses;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0xA0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> previousOrientations;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0xB0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientations;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0xC0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> angularVelocities;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0xD0")]
		[ReadOnly]
		public float4 gravity;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0xE0")]
		[ReadOnly]
		public float deltaTime;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0xE4")]
		[ReadOnly]
		public bool is2D;
	}
}
