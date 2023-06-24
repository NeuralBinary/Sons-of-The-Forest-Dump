using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[BurstCompile]
	internal struct ApplyInertialForcesJob : IJobParallelFor
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x27A12D0", Offset = "0x279F8D0", VA = "0x1827A12D0", Slot = "4")]
		public void Execute(int index)
		{
		}

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<int> activeParticles;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<float4> positions;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<float> invMasses;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public float4 angularVel;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public float4 inertialAccel;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public float4 eulerAccel;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public float worldLinearInertiaScale;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x64")]
		[ReadOnly]
		public float worldAngularInertiaScale;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x68")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> velocities;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x78")]
		[ReadOnly]
		public float deltaTime;
	}
}
