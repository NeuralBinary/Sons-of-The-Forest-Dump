using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class BurstTetherConstraintsBatch : BurstConstraintsBatchImpl, ITetherConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000380 RID: 896 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x2795450", Offset = "0x2793A50", VA = "0x182795450")]
		public BurstTetherConstraintsBatch(BurstTetherConstraints constraints)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x27954C0", Offset = "0x2793AC0", VA = "0x1827954C0", Slot = "15")]
		public void SetTetherConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List maxLengthScale, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2795690", Offset = "0x2793C90", VA = "0x182795690", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2795990", Offset = "0x2793F90", VA = "0x182795990", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float2> maxLengthScale;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float> stiffnesses;

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		[BurstCompile]
		public struct TetherConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000384 RID: 900 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x2795CD0", Offset = "0x27942D0", VA = "0x182795CD0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float2> maxLengthScale;

			// Token: 0x040003EC RID: 1004
			[Token(Token = "0x40003EC")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> stiffnesses;

			// Token: 0x040003ED RID: 1005
			[Token(Token = "0x40003ED")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float> lambdas;

			// Token: 0x040003EE RID: 1006
			[Token(Token = "0x40003EE")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040003EF RID: 1007
			[Token(Token = "0x40003EF")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040003F0 RID: 1008
			[Token(Token = "0x40003F0")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003F1 RID: 1009
			[Token(Token = "0x40003F1")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003F2 RID: 1010
			[Token(Token = "0x40003F2")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public float deltaTimeSqr;
		}

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		[BurstCompile]
		public struct ApplyTetherConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000385 RID: 901 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x2795F00", Offset = "0x2794500", VA = "0x182795F00", Slot = "4")]
			public void Execute(int index)
			{
			}

			// Token: 0x040003F3 RID: 1011
			[Token(Token = "0x40003F3")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeSlice<int> particleIndices;

			// Token: 0x040003F4 RID: 1012
			[Token(Token = "0x40003F4")]
			[FieldOffset(Offset = "0x10")]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x20")]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x40003F6")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public float sorFactor;
		}
	}
}
