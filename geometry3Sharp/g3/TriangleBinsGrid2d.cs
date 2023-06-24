using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class TriangleBinsGrid2d
	{
		// Token: 0x06001E2C RID: 7724 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x1F8D8C0", Offset = "0x1F8BEC0", VA = "0x181F8D8C0")]
		public TriangleBinsGrid2d(AxisAlignedBox2d bounds, int numCells)
		{
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x000151DC File Offset: 0x000133DC
		[Token(Token = "0x1700047D")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0xFB0950", Offset = "0xFAEF50", VA = "0x180FB0950")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x1F8DAB0", Offset = "0x1F8C0B0", VA = "0x181F8DAB0")]
		public void InsertTriangle(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x1F8DAE0", Offset = "0x1F8C0E0", VA = "0x181F8DAE0")]
		public void InsertTriangleUnsafe(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c)
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x1F8DB10", Offset = "0x1F8C110", VA = "0x181F8DB10")]
		public void RemoveTriangle(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c)
		{
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x1F8DB40", Offset = "0x1F8C140", VA = "0x181F8DB40")]
		public void RemoveTriangleUnsafe(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c)
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000151F4 File Offset: 0x000133F4
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x1F8DB70", Offset = "0x1F8C170", VA = "0x181F8DB70")]
		public int FindContainingTriangle(Vector2d query_pt, Func<int, Vector2d, bool> containsF, [Optional] Func<int, bool> ignoreF)
		{
			return 0;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x1F8DF20", Offset = "0x1F8C520", VA = "0x181F8DF20")]
		public void FindTrianglesInRange(AxisAlignedBox2d range, HashSet<int> triangles)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x1F8E2B0", Offset = "0x1F8C8B0", VA = "0x181F8E2B0")]
		private void insert_triangle(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c, bool threadsafe = true)
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x1F8E570", Offset = "0x1F8CB70", VA = "0x181F8E570")]
		private void remove_triangle(int triangle_id, ref Vector2d a, ref Vector2d b, ref Vector2d c, bool threadsafe = true)
		{
		}

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ShiftGridIndexer2 indexer;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AxisAlignedBox2d bounds;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SmallListSet bins_list;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int bins_x;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int bins_y;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AxisAlignedBox2i grid_bounds;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SpinLock spinlock;
	}
}
