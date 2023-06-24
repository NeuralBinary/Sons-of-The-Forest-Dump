using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public abstract class TriangulationContext
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x28AE6C0", Offset = "0x28ACCC0", VA = "0x1828AE6C0")]
		protected TriangulationContext()
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public TriangulationDebugContext DebugContext
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public TriangulationMode TriangulationMode
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return TriangulationMode.Unconstrained;
			}
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public Triangulatable Triangulatable
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public int StepCount
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x993AE0", Offset = "0x9920E0", VA = "0x180993AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x28AE8A0", Offset = "0x28ACEA0", VA = "0x1828AE8A0")]
		public void Done()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C0 RID: 192
		[Token(Token = "0x17000021")]
		public abstract TriangulationAlgorithm Algorithm { [Token(Token = "0x60000C0")] get; }

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x28AE8B0", Offset = "0x28ACEB0", VA = "0x1828AE8B0", Slot = "5")]
		public virtual void PrepareTriangulation(Triangulatable t)
		{
		}

		// Token: 0x060000C2 RID: 194
		[Token(Token = "0x60000C2")]
		public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b);

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void Update(string message)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x28AE9C0", Offset = "0x28ACFC0", VA = "0x1828AE9C0", Slot = "7")]
		public virtual void Clear()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public virtual bool IsDebugEnabled
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x14B6A50", Offset = "0x14B5050", VA = "0x1814B6A50", Slot = "9")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000023")]
		public DTSweepDebugContext DTDebugContext
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x28AEA40", Offset = "0x28AD040", VA = "0x1828AEA40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<DelaunayTriangle> Triangles;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<TriangulationPoint> Points;
	}
}
