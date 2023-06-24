using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public class BurstDensityConstraints : BurstConstraintsImpl<BurstDensityConstraintsBatch>
	{
		// Token: 0x06000303 RID: 771 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x277E670", Offset = "0x277CC70", VA = "0x18277E670")]
		public BurstDensityConstraints(BurstSolverImpl solver)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x277E750", Offset = "0x277CD50", VA = "0x18277E750", Slot = "13")]
		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x277E860", Offset = "0x277CE60", VA = "0x18277E860", Slot = "12")]
		public override void Dispose()
		{
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x277E8E0", Offset = "0x277CEE0", VA = "0x18277E8E0", Slot = "14")]
		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x277E9B0", Offset = "0x277CFB0", VA = "0x18277E9B0", Slot = "16")]
		protected override JobHandle EvaluateSequential(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x277EA10", Offset = "0x277D010", VA = "0x18277EA10", Slot = "17")]
		protected override JobHandle EvaluateParallel(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x277ED50", Offset = "0x277D350", VA = "0x18277ED50")]
		public JobHandle ApplyVelocityCorrections(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x277F180", Offset = "0x277D780", VA = "0x18277F180")]
		public JobHandle CalculateAnisotropyLaplacianSmoothing(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x277F680", Offset = "0x277DC80", VA = "0x18277F680")]
		private JobHandle UpdateInteractions(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000030EC File Offset: 0x000012EC
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x277FCA0", Offset = "0x277E2A0", VA = "0x18277FCA0")]
		private JobHandle CalculateLambdas(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003104 File Offset: 0x00001304
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2780050", Offset = "0x277E650", VA = "0x182780050")]
		private JobHandle ApplyVorticityAndAtmosphere(JobHandle inputDeps, float deltaTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000311C File Offset: 0x0000131C
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x27803B0", Offset = "0x277E9B0", VA = "0x1827803B0")]
		private JobHandle IdentityAnisotropy(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2780620", Offset = "0x277EC20", VA = "0x182780620")]
		private JobHandle AverageSmoothPositions(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x2780880", Offset = "0x277EE80", VA = "0x182780880")]
		private JobHandle AverageAnisotropy(JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x28")]
		public NativeList<int> fluidParticles;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x38")]
		public NativeArray<float4> eta;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x48")]
		public NativeArray<float4> smoothPositions;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x58")]
		public NativeArray<float3x3> anisotropies;

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		[BurstCompile]
		public struct ClearFluidDataJob : IJobParallelFor
		{
			// Token: 0x06000311 RID: 785 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2780B60", Offset = "0x277F160", VA = "0x182780B60", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x10")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> fluidData;
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		[BurstCompile]
		public struct UpdateInteractionsJob : IJobParallelFor
		{
			// Token: 0x06000312 RID: 786 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2780BC0", Offset = "0x277F1C0", VA = "0x182780BC0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> radii;

			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public Poly6Kernel densityKernel;

			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x28")]
			[ReadOnly]
			public SpikyKernel gradientKernel;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x30")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<FluidInteraction> pairs;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public BatchData batchData;
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		[BurstCompile]
		public struct CalculateLambdasJob : IJobParallelFor
		{
			// Token: 0x06000313 RID: 787 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x2780F10", Offset = "0x277F510", VA = "0x182780F10", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float> radii;

			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> surfaceTension;

			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public Poly6Kernel densityKernel;

			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			[FieldOffset(Offset = "0x58")]
			[ReadOnly]
			public SpikyKernel gradientKernel;

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> normals;

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> vorticity;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> fluidData;
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		[BurstCompile]
		public struct ApplyVorticityConfinementAndAtmosphere : IJobParallelFor
		{
			// Token: 0x06000314 RID: 788 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x2781130", Offset = "0x277F730", VA = "0x182781130", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> wind;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> vorticities;

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> atmosphericDrag;

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> atmosphericPressure;

			// Token: 0x040002C0 RID: 704
			[Token(Token = "0x40002C0")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float> vorticityConfinement;

			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float> restDensities;

			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float4> normals;

			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<float4> fluidData;

			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			[FieldOffset(Offset = "0x90")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<float4> eta;

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0xA0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> velocities;

			// Token: 0x040002C6 RID: 710
			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public float dt;
		}

		// Token: 0x02000081 RID: 129
		[Token(Token = "0x2000081")]
		[BurstCompile]
		public struct IdentityAnisotropyJob : IJobParallelFor
		{
			// Token: 0x06000315 RID: 789 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2781500", Offset = "0x277FB00", VA = "0x182781500", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x20")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> principalAxes;
		}

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		[BurstCompile]
		public struct AverageSmoothPositionsJob : IJobParallelFor
		{
			// Token: 0x06000316 RID: 790 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x27815D0", Offset = "0x277FBD0", VA = "0x1827815D0", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> renderablePositions;

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x20")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> smoothPositions;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		[BurstCompile]
		public struct AverageAnisotropyJob : IJobParallelFor
		{
			// Token: 0x06000317 RID: 791 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2781660", Offset = "0x277FC60", VA = "0x182781660", Slot = "4")]
			public void Execute(int p)
			{
			}

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> fluidParticles;

			// Token: 0x040002CE RID: 718
			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> principalRadii;

			// Token: 0x040002CF RID: 719
			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public float maxAnisotropy;

			// Token: 0x040002D0 RID: 720
			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x28")]
			[ReadOnly]
			[DeallocateOnJobCompletion]
			public NativeArray<float4> smoothPositions;

			// Token: 0x040002D1 RID: 721
			[Token(Token = "0x40002D1")]
			[FieldOffset(Offset = "0x38")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<float3x3> anisotropies;

			// Token: 0x040002D2 RID: 722
			[Token(Token = "0x40002D2")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> renderablePositions;

			// Token: 0x040002D3 RID: 723
			[Token(Token = "0x40002D3")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> principalAxes;
		}
	}
}
