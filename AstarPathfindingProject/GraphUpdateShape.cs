using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public class GraphUpdateShape
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700009D")]
		public Vector3[] points
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x6422E0", Offset = "0x6408E0", VA = "0x1806422E0")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700009E")]
		public bool convex
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x642360", Offset = "0x640960", VA = "0x180642360")]
			set
			{
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x6423B0", Offset = "0x6409B0", VA = "0x1806423B0")]
		public GraphUpdateShape()
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x642470", Offset = "0x640A70", VA = "0x180642470")]
		public GraphUpdateShape(Vector3[] points, bool convex, Matrix4x4 matrix, float minimumHeight)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x642A10", Offset = "0x641010", VA = "0x180642A10")]
		private void CalculateConvexHull()
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x642AC0", Offset = "0x6410C0", VA = "0x180642AC0")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x642B90", Offset = "0x641190", VA = "0x180642B90")]
		public static Bounds GetBounds(Vector3[] points, Matrix4x4 matrix, float minimumHeight)
		{
			return default(Bounds);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x643020", Offset = "0x641620", VA = "0x180643020")]
		private static Bounds GetBounds(Vector3[] points, Vector3 right, Vector3 up, Vector3 forward, Vector3 origin, float minimumHeight)
		{
			return default(Bounds);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000383C File Offset: 0x00001A3C
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x643500", Offset = "0x641B00", VA = "0x180643500")]
		public bool Contains(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x643590", Offset = "0x641B90", VA = "0x180643590")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] _points;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x18")]
		private Vector3[] _convexPoints;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x20")]
		private bool _convex;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 right;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 forward;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 up;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 origin;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x54")]
		public float minimumHeight;
	}
}
