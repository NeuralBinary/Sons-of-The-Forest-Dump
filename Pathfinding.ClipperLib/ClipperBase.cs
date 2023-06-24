using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class ClipperBase
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x283A510", Offset = "0x2838B10", VA = "0x18283A510")]
		internal ClipperBase()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x283A670", Offset = "0x2838C70", VA = "0x18283A670")]
		internal static bool near_zero(double val)
		{
			return default(bool);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public bool PreserveCollinear
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x66E8C0", Offset = "0x66CEC0", VA = "0x18066E8C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x66E8D0", Offset = "0x66CED0", VA = "0x18066E8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x283A690", Offset = "0x2838C90", VA = "0x18283A690")]
		internal static bool IsHorizontal(TEdge e)
		{
			return default(bool);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x283A6B0", Offset = "0x2838CB0", VA = "0x18283A6B0")]
		internal bool PointIsVertex(IntPoint pt, OutPt pp)
		{
			return default(bool);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x283A710", Offset = "0x2838D10", VA = "0x18283A710")]
		internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x283A920", Offset = "0x2838F20", VA = "0x18283A920")]
		internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x283A9F0", Offset = "0x2838FF0", VA = "0x18283A9F0")]
		internal bool PointInPolygon(IntPoint pt, OutPt pp, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x283AC50", Offset = "0x2839250", VA = "0x18283AC50")]
		internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x283ADB0", Offset = "0x28393B0", VA = "0x18283ADB0")]
		protected static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x283AEF0", Offset = "0x28394F0", VA = "0x18283AEF0")]
		protected static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x283B040", Offset = "0x2839640", VA = "0x18283B040", Slot = "4")]
		public virtual void Clear()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x283B320", Offset = "0x2839920", VA = "0x18283B320")]
		private void DisposeLocalMinimaList()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x283B460", Offset = "0x2839A60", VA = "0x18283B460")]
		private void RangeTest(IntPoint Pt, ref bool useFullRange)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x283B540", Offset = "0x2839B40", VA = "0x18283B540")]
		private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x283B620", Offset = "0x2839C20", VA = "0x18283B620")]
		private void InitEdge2(TEdge e, PolyType polyType)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x283B6C0", Offset = "0x2839CC0", VA = "0x18283B6C0")]
		public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed)
		{
			return default(bool);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x283C970", Offset = "0x283AF70", VA = "0x18283C970")]
		public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x283CA50", Offset = "0x283B050", VA = "0x18283CA50")]
		public bool AddPolygon(List<IntPoint> pg, PolyType polyType)
		{
			return default(bool);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x283CA70", Offset = "0x283B070", VA = "0x18283CA70")]
		public bool AddPolygons(List<List<IntPoint>> ppg, PolyType polyType)
		{
			return default(bool);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x283CB50", Offset = "0x283B150", VA = "0x18283CB50")]
		internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3)
		{
			return default(bool);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x283CC10", Offset = "0x283B210", VA = "0x18283CC10")]
		private TEdge RemoveEdge(TEdge e)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x283CD50", Offset = "0x283B350", VA = "0x18283CD50")]
		private TEdge GetLastHorz(TEdge Edge)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x283CDA0", Offset = "0x283B3A0", VA = "0x18283CDA0")]
		private bool SharedVertWithPrevAtTop(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x283CE80", Offset = "0x283B480", VA = "0x18283CE80")]
		private bool SharedVertWithNextIsBot(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x283CFE0", Offset = "0x283B5E0", VA = "0x18283CFE0")]
		private bool MoreBelow(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x283D0C0", Offset = "0x283B6C0", VA = "0x18283D0C0")]
		private bool JustBeforeLocMin(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x283D270", Offset = "0x283B870", VA = "0x18283D270")]
		private bool MoreAbove(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x283D330", Offset = "0x283B930", VA = "0x18283D330")]
		private bool AllHorizontal(TEdge Edge)
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x283D380", Offset = "0x283B980", VA = "0x18283D380")]
		private void SetDx(TEdge e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x283D3E0", Offset = "0x283B9E0", VA = "0x18283D3E0")]
		private void DoMinimaLML(TEdge E1, TEdge E2, bool IsClosed)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x283D7B0", Offset = "0x283BDB0", VA = "0x18283D7B0")]
		private TEdge DescendToMin(ref TEdge E)
		{
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x283DA70", Offset = "0x283C070", VA = "0x18283DA70")]
		private void AscendToMax(ref TEdge E, bool Appending, bool IsClosed)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x283DCB0", Offset = "0x283C2B0", VA = "0x18283DCB0")]
		private TEdge AddBoundsToLML(TEdge E, bool Closed)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x283DF50", Offset = "0x283C550", VA = "0x18283DF50")]
		private void InsertLocalMinima(LocalMinima newLm)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x283E160", Offset = "0x283C760", VA = "0x18283E160")]
		protected void PopLocalMinima()
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x283E1C0", Offset = "0x283C7C0", VA = "0x18283E1C0")]
		private void ReverseHorizontal(TEdge e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x283E1F0", Offset = "0x283C7F0", VA = "0x18283E1F0", Slot = "5")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x283E2B0", Offset = "0x283C8B0", VA = "0x18283E2B0")]
		public IntRect GetBounds()
		{
			return default(IntRect);
		}

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		protected const double horizontal = -3.4E+38;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		protected const int Skip = -2;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		protected const int Unassigned = -1;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		protected const double tolerance = 1E-20;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		internal const long loRange = 1073741823L;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		internal const long hiRange = 4611686018427387903L;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		internal LocalMinima m_MinimaList;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x18")]
		internal LocalMinima m_CurrentLM;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x20")]
		internal List<List<TEdge>> m_edges;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x28")]
		internal bool m_UseFullRange;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x29")]
		internal bool m_HasOpenPaths;
	}
}
