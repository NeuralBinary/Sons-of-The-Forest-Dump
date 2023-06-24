using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class Triangulator
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000006")]
		public List<Vector2> Points
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5BB370", Offset = "0x5B9970", VA = "0x1805BB370")]
		public Triangulator(Vector2[] points)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5BB4C0", Offset = "0x5B9AC0", VA = "0x1805BB4C0")]
		public Triangulator(Vector2[] points, bool invertY = true)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5BB770", Offset = "0x5B9D70", VA = "0x1805BB770")]
		public int[] Triangulate()
		{
			return null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5BBAF0", Offset = "0x5BA0F0", VA = "0x1805BBAF0")]
		private float Area()
		{
			return 0f;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5BBBC0", Offset = "0x5BA1C0", VA = "0x1805BBBC0")]
		private bool Snip(int u, int v, int w, int n, int[] V)
		{
			return default(bool);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5BBE40", Offset = "0x5BA440", VA = "0x1805BBE40")]
		private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3)
		{
			return default(bool);
		}

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x10")]
		private List<Vector2> m_points;
	}
}
