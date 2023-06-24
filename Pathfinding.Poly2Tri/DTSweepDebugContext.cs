using System;
using Il2CppDummyDll;

namespace Pathfinding.Poly2Tri
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class DTSweepDebugContext : TriangulationDebugContext
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public DTSweepDebugContext(DTSweepContext tcx)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public DelaunayTriangle PrimaryTriangle
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x28AD580", Offset = "0x28ABB80", VA = "0x1828AD580")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public DelaunayTriangle SecondaryTriangle
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x28AD610", Offset = "0x28ABC10", VA = "0x1828AD610")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public TriangulationPoint ActivePoint
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x28AD6A0", Offset = "0x28ABCA0", VA = "0x1828AD6A0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		public AdvancingFrontNode ActiveNode
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x28AD730", Offset = "0x28ABD30", VA = "0x1828AD730")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public DTSweepConstraint ActiveConstraint
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x28AD7C0", Offset = "0x28ABDC0", VA = "0x1828AD7C0")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x17000014")]
		public bool IsDebugContext
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x28AD850", Offset = "0x28ABE50", VA = "0x1828AD850", Slot = "4")]
		public override void Clear()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x18")]
		private DelaunayTriangle _primaryTriangle;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		private DelaunayTriangle _secondaryTriangle;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x28")]
		private TriangulationPoint _activePoint;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x30")]
		private AdvancingFrontNode _activeNode;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x38")]
		private DTSweepConstraint _activeConstraint;
	}
}
