using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class BurstSkinConstraintsBatch : BurstConstraintsBatchImpl, ISkinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000365 RID: 869 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2791F40", Offset = "0x2790540", VA = "0x182791F40")]
		public BurstSkinConstraintsBatch(BurstSkinConstraints constraints)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2791FB0", Offset = "0x27905B0", VA = "0x182791FB0", Slot = "15")]
		public void SetSkinConstraints(ObiNativeIntList particleIndices, ObiNativeVector4List skinPoints, ObiNativeVector4List skinNormals, ObiNativeFloatList skinRadiiBackstop, ObiNativeFloatList skinCompliance, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x2792230", Offset = "0x2790830", VA = "0x182792230", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2792580", Offset = "0x2790B80", VA = "0x182792580", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float4> skinPoints;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float4> skinNormals;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<float> skinRadiiBackstop;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float> skinCompliance;

		// Token: 0x020000A4 RID: 164
		[Token(Token = "0x20000A4")]
		[BurstCompile]
		public struct SkinConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000369 RID: 873 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2792800", Offset = "0x2790E00", VA = "0x182792800", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003AC RID: 940
			[Token(Token = "0x40003AC")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003AD RID: 941
			[Token(Token = "0x40003AD")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> skinPoints;

			// Token: 0x040003AE RID: 942
			[Token(Token = "0x40003AE")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> skinNormals;

			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float3> skinRadiiBackstop;

			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> skinCompliance;

			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float> lambdas;

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x90")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x040003B6 RID: 950
			[Token(Token = "0x40003B6")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public float deltaTimeSqr;
		}

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000A5")]
		[BurstCompile]
		public struct ApplySkinConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600036A RID: 874 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2792C20", Offset = "0x2791220", VA = "0x182792C20", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003B7 RID: 951
			[Token(Token = "0x40003B7")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x040003B8 RID: 952
			[Token(Token = "0x40003B8")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;
		}
	}
}
