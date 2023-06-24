using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class TriangulationPoint
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1F93BE0", Offset = "0x1F921E0", VA = "0x181F93BE0")]
		public TriangulationPoint(double x, double y)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public List<DTSweepConstraint> Edges
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x28AEAC0", Offset = "0x28AD0C0", VA = "0x1828AEAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public float Xf
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x28AECF0", Offset = "0x28AD2F0", VA = "0x1828AECF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x28AED00", Offset = "0x28AD300", VA = "0x1828AED00")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public float Yf
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x28AED10", Offset = "0x28AD310", VA = "0x1828AED10")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x28AED20", Offset = "0x28AD320", VA = "0x1828AED20")]
			set
			{
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x28AED30", Offset = "0x28AD330", VA = "0x1828AED30")]
		public void AddEdge(DTSweepConstraint e)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000027")]
		public bool HasEdges
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x28AEE60", Offset = "0x28AD460", VA = "0x1828AEE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		public double X;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		public double Y;
	}
}
