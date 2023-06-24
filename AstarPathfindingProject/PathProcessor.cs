using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine.Profiling;

namespace Pathfinding
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class PathProcessor
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060003B1 RID: 945 RVA: 0x00002082 File Offset: 0x00000282
		// (remove) Token: 0x060003B2 RID: 946 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x14000002")]
		public event Action<Path> OnPathPreSearch
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x668C80", Offset = "0x667280", VA = "0x180668C80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x668DF0", Offset = "0x6673F0", VA = "0x180668DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060003B3 RID: 947 RVA: 0x00002082 File Offset: 0x00000282
		// (remove) Token: 0x060003B4 RID: 948 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x14000003")]
		public event Action<Path> OnPathPostSearch
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x668F60", Offset = "0x667560", VA = "0x180668F60")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x6690D0", Offset = "0x6676D0", VA = "0x1806690D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003B5 RID: 949 RVA: 0x00002082 File Offset: 0x00000282
		// (remove) Token: 0x060003B6 RID: 950 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x14000004")]
		public event Action OnQueueUnblocked
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x669240", Offset = "0x667840", VA = "0x180669240")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x669330", Offset = "0x667930", VA = "0x180669330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x170000B8")]
		public int NumThreads
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x669420", Offset = "0x667A20", VA = "0x180669420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x170000B9")]
		public bool IsUsingMultithreading
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x669440", Offset = "0x667A40", VA = "0x180669440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x669450", Offset = "0x667A50", VA = "0x180669450")]
		internal PathProcessor(AstarPath astar, PathReturnQueue returnQueue, int processors, bool multithreaded)
		{
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x66A0C0", Offset = "0x6686C0", VA = "0x18066A0C0")]
		private int Lock(bool block)
		{
			return 0;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x66A1D0", Offset = "0x6687D0", VA = "0x18066A1D0")]
		private void Unlock(int id)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x66A2B0", Offset = "0x6688B0", VA = "0x18066A2B0")]
		public PathProcessor.GraphUpdateLock PausePathfinding(bool block)
		{
			return default(PathProcessor.GraphUpdateLock);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x66A2D0", Offset = "0x6688D0", VA = "0x18066A2D0")]
		public void TickNonMultithreaded()
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x66A400", Offset = "0x668A00", VA = "0x18066A400")]
		public void JoinThreads()
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x66A550", Offset = "0x668B50", VA = "0x18066A550")]
		public void AbortThreads()
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x66A600", Offset = "0x668C00", VA = "0x18066A600")]
		public int GetNewNodeIndex()
		{
			return 0;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x66A660", Offset = "0x668C60", VA = "0x18066A660")]
		public void InitializeNode(GraphNode node)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x66A880", Offset = "0x668E80", VA = "0x18066A880")]
		public void DestroyNode(GraphNode node)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x66AA90", Offset = "0x669090", VA = "0x18066AA90")]
		private void CalculatePathsThreaded(PathHandler pathHandler)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x66B400", Offset = "0x669A00", VA = "0x18066B400")]
		private IEnumerator CalculatePaths(PathHandler pathHandler)
		{
			return null;
		}

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ThreadControlQueue queue;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x30")]
		private readonly AstarPath astar;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x38")]
		private readonly PathReturnQueue returnQueue;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x40")]
		private readonly PathHandler[] pathHandlers;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x48")]
		private readonly Thread[] threads;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x50")]
		private IEnumerator threadCoroutine;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x58")]
		private int nextNodeIndex;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x60")]
		private readonly Stack<int> nodeIndexPool;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<int> locks;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x70")]
		private int nextLockID;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x78")]
		private CustomSampler profilingSampler;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public struct GraphUpdateLock
		{
			// Token: 0x060003C5 RID: 965 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x66B500", Offset = "0x669B00", VA = "0x18066B500")]
			public GraphUpdateLock(PathProcessor pathProcessor, bool block)
			{
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00003FA4 File Offset: 0x000021A4
			[Token(Token = "0x170000BA")]
			public bool Held
			{
				[Token(Token = "0x60003C6")]
				[Address(RVA = "0x66B680", Offset = "0x669C80", VA = "0x18066B680")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x66B6E0", Offset = "0x669CE0", VA = "0x18066B6E0")]
			public void Release()
			{
			}

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x0")]
			private PathProcessor pathProcessor;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x8")]
			private int id;
		}
	}
}
