using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding.ClipperLib
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class PolyNode
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x28396B0", Offset = "0x2837CB0", VA = "0x1828396B0")]
		public PolyNode()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2839800", Offset = "0x2837E00", VA = "0x182839800")]
		private bool IsHoleNode()
		{
			return default(bool);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000002")]
		public int ChildCount
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2839820", Offset = "0x2837E20", VA = "0x182839820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		public List<IntPoint> Contour
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2839860", Offset = "0x2837E60", VA = "0x182839860")]
		internal void AddChild(PolyNode Child)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2839960", Offset = "0x2837F60", VA = "0x182839960")]
		public PolyNode GetNext()
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x28399E0", Offset = "0x2837FE0", VA = "0x1828399E0")]
		internal PolyNode GetNextSiblingUp()
		{
			return null;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000004")]
		public List<PolyNode> Childs
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000005")]
		public PolyNode Parent
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x17000006")]
		public bool IsHole
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2839800", Offset = "0x2837E00", VA = "0x182839800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020B8 File Offset: 0x000002B8
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public bool IsOpen
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		internal PolyNode m_Parent;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		internal List<IntPoint> m_polygon;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		internal int m_Index;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		internal List<PolyNode> m_Childs;
	}
}
