using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[BurstCompile]
	internal struct ParticleToBoundsJob : IJobParallelFor
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x27A1640", Offset = "0x279FC40", VA = "0x1827A1640", Slot = "4")]
		public void Execute(int i)
		{
		}

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float4> positions;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float4> radii;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x30")]
		public NativeArray<BurstAabb> bounds;
	}
}
