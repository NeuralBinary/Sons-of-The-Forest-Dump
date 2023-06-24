using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class PointHashGrid2d<T>
	{
		// Token: 0x06001DE3 RID: 7651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE3")]
		public PointHashGrid2d(double cellSize, T invalidValue)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000477")]
		public T InvalidValue
		{
			[Token(Token = "0x6001DE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE5")]
		public void InsertPoint(T value, Vector2d pos)
		{
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE6")]
		public void InsertPointUnsafe(T value, Vector2d pos)
		{
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x00014F6C File Offset: 0x0001316C
		[Token(Token = "0x6001DE7")]
		public bool RemovePoint(T value, Vector2d pos)
		{
			return default(bool);
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00014F84 File Offset: 0x00013184
		[Token(Token = "0x6001DE8")]
		public bool RemovePointUnsafe(T value, Vector2d pos)
		{
			return default(bool);
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DE9")]
		public void UpdatePoint(T value, Vector2d old_pos, Vector2d new_pos)
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DEA")]
		public void UpdatePointUnsafe(T value, Vector2d old_pos, Vector2d new_pos)
		{
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00014F9C File Offset: 0x0001319C
		[Token(Token = "0x6001DEB")]
		public KeyValuePair<T, double> FindNearestInRadius(Vector2d query_pt, double radius, Func<T, double> distF, [Optional] Func<T, bool> ignoreF)
		{
			return default(KeyValuePair<T, double>);
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DEC")]
		private void insert_point(T value, Vector2i idx, bool threadsafe = true)
		{
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x00014FB4 File Offset: 0x000131B4
		[Token(Token = "0x6001DED")]
		private bool remove_point(T value, Vector2i idx, bool threadsafe = true)
		{
			return default(bool);
		}

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Vector2i, List<T>> Hash;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ScaleGridIndexer2 Indexer;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T invalidValue;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SpinLock spinlock;
	}
}
