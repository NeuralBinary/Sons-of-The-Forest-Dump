using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	[AddComponentMenu("Pathfinding/Local Avoidance/RVO Simulator")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_r_v_o_1_1_r_v_o_simulator.php")]
	[ExecuteInEditMode]
	public class RVOSimulator : VersionedMonoBehaviour
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700017F")]
		public static RVOSimulator active
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x727AF0", Offset = "0x7260F0", VA = "0x180727AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x727B30", Offset = "0x726130", VA = "0x180727B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x727BC0", Offset = "0x7261C0", VA = "0x180727BC0")]
		public Simulator GetSimulator()
		{
			return null;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x727C00", Offset = "0x726200", VA = "0x180727C00")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x727C10", Offset = "0x726210", VA = "0x180727C10", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x727DA0", Offset = "0x7263A0", VA = "0x180727DA0")]
		private void Update()
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x727EA0", Offset = "0x7264A0", VA = "0x180727EA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x727ED0", Offset = "0x7264D0", VA = "0x180727ED0")]
		public RVOSimulator()
		{
		}

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Desired FPS for rvo simulation. It is usually not necessary to run a crowd simulation at a very high fps.\nUsually 10-30 fps is enough, but can be increased for better quality.\nThe rvo simulation will never run at a higher fps than the game")]
		public int desiredSimulationFPS;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Number of RVO worker threads. If set to None, no multithreading will be used.")]
		public ThreadCount workerThreads;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Calculate local avoidance in between frames.\nThis can increase jitter in the agents' movement so use it only if you really need the performance boost. It will also reduce the responsiveness of the agents to the commands you send to them.")]
		public bool doubleBuffering;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 0.2f)]
		[Tooltip("Bias agents to pass each other on the right side.\nIf the desired velocity of an agent puts it on a collision course with another agent or an obstacle its desired velocity will be rotated this number of radians (1 radian is approximately 57°) to the right. This helps to break up symmetries and makes it possible to resolve some situations much faster.\n\nWhen many agents have the same goal this can however have the side effect that the group clustered around the target point may as a whole start to spin around the target point.")]
		public float symmetryBreakingBias;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Determines if the XY (2D) or XZ (3D) plane is used for movement")]
		public MovementPlane movementPlane;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x3C")]
		public bool drawObstacles;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x40")]
		private Simulator simulator;
	}
}
