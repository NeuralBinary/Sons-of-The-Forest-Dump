using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class SegmentHashGrid2d<T>
	{
		// Token: 0x06001E0C RID: 7692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0C")]
		public SegmentHashGrid2d(double cellSize, T invalidValue)
		{
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0D")]
		public void InsertSegment(T value, Vector2d center, double extent)
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0E")]
		public void InsertSegmentUnsafe(T value, Vector2d center, double extent)
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0001511C File Offset: 0x0001331C
		[Token(Token = "0x6001E0F")]
		public bool RemoveSegment(T value, Vector2d center)
		{
			return default(bool);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00015134 File Offset: 0x00013334
		[Token(Token = "0x6001E10")]
		public bool RemoveSegmentUnsafe(T value, Vector2d center)
		{
			return default(bool);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E11")]
		public void UpdateSegment(T value, Vector2d old_center, Vector2d new_center, double new_extent)
		{
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E12")]
		public void UpdateSegmentUnsafe(T value, Vector2d old_center, Vector2d new_center, double new_extent)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0001514C File Offset: 0x0001334C
		[Token(Token = "0x6001E13")]
		public KeyValuePair<T, double> FindNearestInRadius(Vector2d query_pt, double radius, Func<T, double> distF, [Optional] Func<T, bool> ignoreF)
		{
			return default(KeyValuePair<T, double>);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00015164 File Offset: 0x00013364
		[Token(Token = "0x6001E14")]
		public KeyValuePair<T, double> FindNearestInSquaredRadius(Vector2d query_pt, double radiusSqr, Func<T, double> distSqrF, [Optional] Func<T, bool> ignoreF)
		{
			return default(KeyValuePair<T, double>);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E15")]
		private void insert_segment(T value, Vector2i idx, bool threadsafe = true)
		{
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0001517C File Offset: 0x0001337C
		[Token(Token = "0x6001E16")]
		private bool remove_segment(T value, Vector2i idx, bool threadsafe = true)
		{
			return default(bool);
		}

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Vector2i, List<T>> Hash;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ScaleGridIndexer2 Indexer;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double MaxExtent;

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T invalidValue;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SpinLock spinlock;
	}
}
