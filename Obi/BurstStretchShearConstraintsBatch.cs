using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public class BurstStretchShearConstraintsBatch : BurstConstraintsBatchImpl, IStretchShearConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000377 RID: 887 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2793E10", Offset = "0x2792410", VA = "0x182793E10")]
		public BurstStretchShearConstraintsBatch(BurstStretchShearConstraints constraints)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2793E80", Offset = "0x2792480", VA = "0x182793E80", Slot = "15")]
		public void SetStretchShearConstraints(ObiNativeIntList particleIndices, ObiNativeIntList orientationIndices, ObiNativeFloatList restLengths, ObiNativeQuaternionList restOrientations, ObiNativeVector3List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2794110", Offset = "0x2792710", VA = "0x182794110", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x27944F0", Offset = "0x2792AF0", VA = "0x1827944F0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> orientationIndices;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float> restLengths;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<quaternion> restOrientations;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float3> stiffnesses;

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		[BurstCompile]
		public struct StretchShearConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600037B RID: 891 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x2794810", Offset = "0x2792E10", VA = "0x182794810", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003D0 RID: 976
			[Token(Token = "0x40003D0")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003D1 RID: 977
			[Token(Token = "0x40003D1")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> orientationIndices;

			// Token: 0x040003D2 RID: 978
			[Token(Token = "0x40003D2")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> restLengths;

			// Token: 0x040003D3 RID: 979
			[Token(Token = "0x40003D3")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<quaternion> restOrientations;

			// Token: 0x040003D4 RID: 980
			[Token(Token = "0x40003D4")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float3> stiffnesses;

			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float3> lambdas;

			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x40003D6")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<float> invRotationalMasses;

			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			[FieldOffset(Offset = "0xA0")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			[FieldOffset(Offset = "0xB0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[FieldOffset(Offset = "0xC0")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[FieldOffset(Offset = "0xD0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[FieldOffset(Offset = "0xE0")]
			[ReadOnly]
			public float deltaTimeSqr;
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		[BurstCompile]
		public struct ApplyStretchShearConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600037C RID: 892 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x2794ED0", Offset = "0x27934D0", VA = "0x182794ED0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> orientationIndices;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040003E3 RID: 995
			[Token(Token = "0x40003E3")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientations;

			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x40003E6")]
			[FieldOffset(Offset = "0x68")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			[FieldOffset(Offset = "0x78")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;
		}
	}
}
