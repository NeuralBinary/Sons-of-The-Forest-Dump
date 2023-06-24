using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public class BurstDensityConstraintsBatch : BurstConstraintsBatchImpl, IDensityConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000318 RID: 792 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x2781A00", Offset = "0x2780000", VA = "0x182781A00")]
		public BurstDensityConstraintsBatch(BurstDensityConstraints constraints)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x2781A70", Offset = "0x2780070", VA = "0x182781A70", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float deltaTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x2781E40", Offset = "0x2780440", VA = "0x182781E40", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2782270", Offset = "0x2780870", VA = "0x182782270")]
		public JobHandle CalculateViscosityAndNormals(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x2782680", Offset = "0x2780C80", VA = "0x182782680")]
		public JobHandle CalculateVorticity(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x27829F0", Offset = "0x2780FF0", VA = "0x1827829F0")]
		public JobHandle AccumulateSmoothPositions(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2782D90", Offset = "0x2781390", VA = "0x182782D90")]
		public JobHandle AccumulateAnisotropy(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x48")]
		public BatchData batchData;

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		[BurstCompile]
		public struct UpdateDensitiesJob : IJobParallelFor
		{
			// Token: 0x06000320 RID: 800 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x27830F0", Offset = "0x27816F0", VA = "0x1827830F0", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> diffusion;

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002DA RID: 730
			[Token(Token = "0x40002DA")]
			[FieldOffset(Offset = "0x50")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> userData;

			// Token: 0x040002DB RID: 731
			[Token(Token = "0x40002DB")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> fluidData;

			// Token: 0x040002DC RID: 732
			[Token(Token = "0x40002DC")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public BatchData batchData;

			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			[FieldOffset(Offset = "0x8C")]
			[ReadOnly]
			public float dt;
		}

		// Token: 0x02000086 RID: 134
		[Token(Token = "0x2000086")]
		[BurstCompile]
		public struct ApplyDensityConstraintsJob : IJobParallelFor
		{
			// Token: 0x06000321 RID: 801 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x2783540", Offset = "0x2781B40", VA = "0x182783540", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> radii;

			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> surfaceTension;

			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public Poly6Kernel densityKernel;

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> positions;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x68")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> fluidData;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x78")]
			[ReadOnly]
			public BatchData batchData;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x94")]
			[ReadOnly]
			public float sorFactor;
		}

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		[BurstCompile]
		public struct NormalsViscosityAndVorticityJob : IJobParallelFor
		{
			// Token: 0x06000322 RID: 802 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2783AD0", Offset = "0x27820D0", VA = "0x182783AD0", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> radii;

			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> viscosities;

			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> fluidData;

			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> velocities;

			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x40002F0")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> vorticities;

			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			[FieldOffset(Offset = "0x90")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> normals;

			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public BatchData batchData;
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		[BurstCompile]
		public struct CalculateVorticityEta : IJobParallelFor
		{
			// Token: 0x06000323 RID: 803 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x2784170", Offset = "0x2782770", VA = "0x182784170", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> vorticities;

			// Token: 0x040002F4 RID: 756
			[Token(Token = "0x40002F4")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040002F5 RID: 757
			[Token(Token = "0x40002F5")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002F6 RID: 758
			[Token(Token = "0x40002F6")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002F7 RID: 759
			[Token(Token = "0x40002F7")]
			[FieldOffset(Offset = "0x40")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> eta;

			// Token: 0x040002F8 RID: 760
			[Token(Token = "0x40002F8")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public BatchData batchData;
		}

		// Token: 0x02000089 RID: 137
		[Token(Token = "0x2000089")]
		[BurstCompile]
		public struct AccumulateSmoothPositionsJob : IJobParallelFor
		{
			// Token: 0x06000324 RID: 804 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x27844D0", Offset = "0x2782AD0", VA = "0x1827844D0", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002F9 RID: 761
			[Token(Token = "0x40002F9")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> renderablePositions;

			// Token: 0x040002FA RID: 762
			[Token(Token = "0x40002FA")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> radii;

			// Token: 0x040002FB RID: 763
			[Token(Token = "0x40002FB")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public Poly6Kernel densityKernel;

			// Token: 0x040002FC RID: 764
			[Token(Token = "0x40002FC")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> smoothPositions;

			// Token: 0x040002FD RID: 765
			[Token(Token = "0x40002FD")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002FE RID: 766
			[Token(Token = "0x40002FE")]
			[FieldOffset(Offset = "0x48")]
			[ReadOnly]
			public BatchData batchData;
		}

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		[BurstCompile]
		public struct AccumulateAnisotropyJob : IJobParallelFor
		{
			// Token: 0x06000325 RID: 805 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x2784810", Offset = "0x2782E10", VA = "0x182784810", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x040002FF RID: 767
			[Token(Token = "0x40002FF")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> renderablePositions;

			// Token: 0x04000300 RID: 768
			[Token(Token = "0x4000300")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> smoothPositions;

			// Token: 0x04000301 RID: 769
			[Token(Token = "0x4000301")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x04000302 RID: 770
			[Token(Token = "0x4000302")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float3x3> anisotropies;

			// Token: 0x04000303 RID: 771
			[Token(Token = "0x4000303")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public BatchData batchData;
		}
	}
}
