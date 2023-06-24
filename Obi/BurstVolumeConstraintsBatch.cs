using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000B3 RID: 179
	[Token(Token = "0x20000B3")]
	public class BurstVolumeConstraintsBatch : BurstConstraintsBatchImpl, IVolumeConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000389 RID: 905 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x2796290", Offset = "0x2794890", VA = "0x182796290")]
		public BurstVolumeConstraintsBatch(BurstVolumeConstraints constraints)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x2796300", Offset = "0x2794900", VA = "0x182796300", Slot = "15")]
		public void SetVolumeConstraints(ObiNativeIntList triangles, ObiNativeIntList firstTriangle, ObiNativeIntList numTriangles, ObiNativeFloatList restVolumes, ObiNativeVector2List pressureStiffness, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x2796580", Offset = "0x2794B80", VA = "0x182796580", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x27968A0", Offset = "0x2794EA0", VA = "0x1827968A0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> firstTriangle;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<int> numTriangles;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<float> restVolumes;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float2> pressureStiffness;

		// Token: 0x020000B4 RID: 180
		[Token(Token = "0x20000B4")]
		[BurstCompile]
		public struct VolumeConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600038D RID: 909 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x2796B60", Offset = "0x2795160", VA = "0x182796B60", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x40003FC")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> triangles;

			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x40003FD")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstTriangle;

			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x40003FE")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numTriangles;

			// Token: 0x040003FF RID: 1023
			[Token(Token = "0x40003FF")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> restVolumes;

			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000400")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float2> pressureStiffness;

			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float> lambdas;

			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000403")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> gradients;

			// Token: 0x04000405 RID: 1029
			[Token(Token = "0x4000405")]
			[FieldOffset(Offset = "0x90")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			[FieldOffset(Offset = "0xA0")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public float deltaTimeSqr;
		}

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		[BurstCompile]
		public struct ApplyVolumeConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600038E RID: 910 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x27973C0", Offset = "0x27959C0", VA = "0x1827973C0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> triangles;

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstTriangle;

			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numTriangles;

			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> positions;

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;
		}
	}
}
