using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public class BurstStitchConstraintsBatch : BurstConstraintsBatchImpl, IStitchConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x0600036E RID: 878 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2792F70", Offset = "0x2791570", VA = "0x182792F70")]
		public BurstStitchConstraintsBatch(BurstStitchConstraints constraints)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2792FE0", Offset = "0x27915E0", VA = "0x182792FE0", Slot = "15")]
		public void SetStitchConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2793150", Offset = "0x2791750", VA = "0x182793150", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2793420", Offset = "0x2791A20", VA = "0x182793420", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float> stiffnesses;

		// Token: 0x020000A8 RID: 168
		[Token(Token = "0x20000A8")]
		[BurstCompile]
		public struct StitchConstraintsBatchJob : IJob
		{
			// Token: 0x06000372 RID: 882 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2793690", Offset = "0x2791C90", VA = "0x182793690", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> stiffnesses;

			// Token: 0x040003BF RID: 959
			[Token(Token = "0x40003BF")]
			[FieldOffset(Offset = "0x20")]
			public NativeArray<float> lambdas;

			// Token: 0x040003C0 RID: 960
			[Token(Token = "0x40003C0")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040003C1 RID: 961
			[Token(Token = "0x40003C1")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040003C2 RID: 962
			[Token(Token = "0x40003C2")]
			[FieldOffset(Offset = "0x50")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003C3 RID: 963
			[Token(Token = "0x40003C3")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x40003C4")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public float deltaTimeSqr;

			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[FieldOffset(Offset = "0x74")]
			[ReadOnly]
			public int activeConstraintCount;
		}

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		[BurstCompile]
		public struct ApplyStitchConstraintsBatchJob : IJob
		{
			// Token: 0x06000373 RID: 883 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x27939B0", Offset = "0x2791FB0", VA = "0x1827939B0", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[FieldOffset(Offset = "0x48")]
			[ReadOnly]
			public int activeConstraintCount;
		}
	}
}
