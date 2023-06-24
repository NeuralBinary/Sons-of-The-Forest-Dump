using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[BurstCompile]
	internal struct BuildSimplexAabbs : IJobParallelFor
	{
		// Token: 0x0600040E RID: 1038 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x27A1840", Offset = "0x279FE40", VA = "0x1827A1840", Slot = "4")]
		public void Execute(int i)
		{
		}

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<float4> radii;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float> fluidRadii;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float4> positions;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public NativeArray<float4> velocities;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public NativeList<int> simplices;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public SimplexCounts simplexCounts;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public NativeArray<int> particleMaterialIndices;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x70")]
		[ReadOnly]
		public NativeArray<BurstCollisionMaterial> collisionMaterials;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x80")]
		[ReadOnly]
		public float collisionMargin;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x84")]
		[ReadOnly]
		public float continuousCollisionDetection;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x88")]
		[ReadOnly]
		public float dt;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x90")]
		public NativeArray<BurstAabb> simplexBounds;
	}
}
