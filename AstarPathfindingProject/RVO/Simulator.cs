using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Pathfinding.RVO.Sampled;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public class Simulator
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700016A")]
		public RVOQuadtree Quadtree
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x000067F4 File Offset: 0x000049F4
		[Token(Token = "0x1700016B")]
		public float DeltaTime
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0000680C File Offset: 0x00004A0C
		[Token(Token = "0x1700016C")]
		public bool Multithreading
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x71D330", Offset = "0x71B930", VA = "0x18071D330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00006824 File Offset: 0x00004A24
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700016D")]
		public float DesiredDeltaTime
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x71D350", Offset = "0x71B950", VA = "0x18071D350")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x71D360", Offset = "0x71B960", VA = "0x18071D360")]
			set
			{
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public List<Agent> GetAgents()
		{
			return null;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public List<ObstacleVertex> GetObstacles()
		{
			return null;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x71D3E0", Offset = "0x71B9E0", VA = "0x18071D3E0")]
		public Simulator(int workers, bool doubleBuffering, MovementPlane movementPlane)
		{
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x71D8A0", Offset = "0x71BEA0", VA = "0x18071D8A0")]
		public void ClearAgents()
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x71D9F0", Offset = "0x71BFF0", VA = "0x18071D9F0")]
		public void OnDestroy()
		{
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x71DBD0", Offset = "0x71C1D0", VA = "0x18071DBD0")]
		public IAgent AddAgent(IAgent agent)
		{
			return null;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x71DE10", Offset = "0x71C410", VA = "0x18071DE10")]
		[Obsolete("Use AddAgent(Vector2,float) instead")]
		public IAgent AddAgent(Vector3 position)
		{
			return null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x71DE30", Offset = "0x71C430", VA = "0x18071DE30")]
		public IAgent AddAgent(Vector2 position, float elevationCoordinate)
		{
			return null;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x71DEB0", Offset = "0x71C4B0", VA = "0x18071DEB0")]
		public void RemoveAgent(IAgent agent)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x71E110", Offset = "0x71C710", VA = "0x18071E110")]
		public ObstacleVertex AddObstacle(ObstacleVertex v)
		{
			return null;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x71E1C0", Offset = "0x71C7C0", VA = "0x18071E1C0")]
		public ObstacleVertex AddObstacle(Vector3[] vertices, float height, bool cycle = true)
		{
			return null;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x71E280", Offset = "0x71C880", VA = "0x18071E280")]
		public ObstacleVertex AddObstacle(Vector3[] vertices, float height, Matrix4x4 matrix, RVOLayer layer = RVOLayer.DefaultObstacle, bool cycle = true)
		{
			return null;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x71E600", Offset = "0x71CC00", VA = "0x18071E600")]
		public ObstacleVertex AddObstacle(Vector3 a, Vector3 b, float height)
		{
			return null;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x71E8E0", Offset = "0x71CEE0", VA = "0x18071E8E0")]
		public void UpdateObstacle(ObstacleVertex obstacle, Vector3[] vertices, Matrix4x4 matrix)
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x71ED80", Offset = "0x71D380", VA = "0x18071ED80")]
		private void ScheduleCleanObstacles()
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void CleanObstacles()
		{
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x71ED90", Offset = "0x71D390", VA = "0x18071ED90")]
		public void RemoveObstacle(ObstacleVertex v)
		{
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
		public void UpdateObstacles()
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x71EE60", Offset = "0x71D460", VA = "0x18071EE60")]
		private void BuildQuadtree()
		{
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x71F120", Offset = "0x71D720", VA = "0x18071F120")]
		private void BlockUntilSimulationStepIsDone()
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x71F1C0", Offset = "0x71D7C0", VA = "0x18071F1C0")]
		private void PreCalculation()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x71F280", Offset = "0x71D880", VA = "0x18071F280")]
		private void CleanAndUpdateObstaclesIfNecessary()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x71F2A0", Offset = "0x71D8A0", VA = "0x18071F2A0")]
		public void Update()
		{
		}

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool doubleBuffering;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x14")]
		private float desiredDeltaTime;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x18")]
		private readonly Simulator.Worker[] workers;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x20")]
		private List<Agent> agents;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x28")]
		public List<ObstacleVertex> obstacles;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x38")]
		private float deltaTime;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x3C")]
		private float lastStep;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x40")]
		private bool doUpdateObstacles;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x41")]
		private bool doCleanObstacles;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x44")]
		public float symmetryBreakingBias;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x48")]
		public readonly MovementPlane movementPlane;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0x50")]
		private Simulator.WorkerContext coroutineWorkerContext;

		// Token: 0x02000153 RID: 339
		[Token(Token = "0x2000153")]
		internal class WorkerContext
		{
			// Token: 0x06000A9C RID: 2716 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x71FD20", Offset = "0x71E320", VA = "0x18071FD20")]
			public WorkerContext()
			{
			}

			// Token: 0x04000753 RID: 1875
			[Token(Token = "0x4000753")]
			[FieldOffset(Offset = "0x10")]
			public Agent.VOBuffer vos;

			// Token: 0x04000754 RID: 1876
			[Token(Token = "0x4000754")]
			public const int KeepCount = 3;

			// Token: 0x04000755 RID: 1877
			[Token(Token = "0x4000755")]
			[FieldOffset(Offset = "0x18")]
			public Vector2[] bestPos;

			// Token: 0x04000756 RID: 1878
			[Token(Token = "0x4000756")]
			[FieldOffset(Offset = "0x20")]
			public float[] bestSizes;

			// Token: 0x04000757 RID: 1879
			[Token(Token = "0x4000757")]
			[FieldOffset(Offset = "0x28")]
			public float[] bestScores;

			// Token: 0x04000758 RID: 1880
			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x30")]
			public Vector2[] samplePos;

			// Token: 0x04000759 RID: 1881
			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x38")]
			public float[] sampleSize;
		}

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		private class Worker
		{
			// Token: 0x06000A9D RID: 2717 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x720060", Offset = "0x71E660", VA = "0x180720060")]
			public Worker(Simulator sim)
			{
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x7203B0", Offset = "0x71E9B0", VA = "0x1807203B0")]
			public void Execute(int task)
			{
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x7203F0", Offset = "0x71E9F0", VA = "0x1807203F0")]
			public void WaitOne()
			{
			}

			// Token: 0x06000AA0 RID: 2720 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x720430", Offset = "0x71EA30", VA = "0x180720430")]
			public void Terminate()
			{
			}

			// Token: 0x06000AA1 RID: 2721 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x720490", Offset = "0x71EA90", VA = "0x180720490")]
			public void Run()
			{
			}

			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x10")]
			public int start;

			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x14")]
			public int end;

			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x18")]
			private readonly ManualResetEventSlim runFlag;

			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x20")]
			private readonly ManualResetEventSlim waitFlag;

			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x28")]
			private readonly Simulator simulator;

			// Token: 0x0400075F RID: 1887
			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0x30")]
			private int task;

			// Token: 0x04000760 RID: 1888
			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x34")]
			private bool terminate;

			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x38")]
			private Simulator.WorkerContext context;
		}
	}
}
