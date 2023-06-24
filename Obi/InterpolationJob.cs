using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[BurstCompile]
	internal struct InterpolationJob : IJobParallelFor
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x27A9790", Offset = "0x27A7D90", VA = "0x1827A9790", Slot = "4")]
		public void Execute(int i)
		{
		}

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<float4> startPositions;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float4> positions;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x20")]
		[WriteOnly]
		public NativeArray<float4> renderablePositions;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<quaternion> startOrientations;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public NativeArray<quaternion> orientations;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x50")]
		[WriteOnly]
		public NativeArray<quaternion> renderableOrientations;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public float deltaTime;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x64")]
		[ReadOnly]
		public float unsimulatedTime;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x68")]
		[ReadOnly]
		public Oni.SolverParameters.Interpolation interpolationMode;
	}
}
