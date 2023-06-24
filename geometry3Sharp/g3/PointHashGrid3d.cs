using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A1 RID: 929
	[Token(Token = "0x20003A1")]
	public class PointHashGrid3d<T>
	{
		// Token: 0x06001DF1 RID: 7665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF1")]
		public PointHashGrid3d(double cellSize, T invalidValue)
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000478")]
		public T InvalidValue
		{
			[Token(Token = "0x6001DF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF3")]
		public void InsertPoint(T value, Vector3d pos)
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF4")]
		public void InsertPointUnsafe(T value, Vector3d pos)
		{
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00014FE4 File Offset: 0x000131E4
		[Token(Token = "0x6001DF5")]
		public bool RemovePoint(T value, Vector3d pos)
		{
			return default(bool);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00014FFC File Offset: 0x000131FC
		[Token(Token = "0x6001DF6")]
		public bool RemovePointUnsafe(T value, Vector3d pos)
		{
			return default(bool);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF7")]
		public void UpdatePoint(T value, Vector3d old_pos, Vector3d new_pos)
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF8")]
		public void UpdatePointUnsafe(T value, Vector3d old_pos, Vector3d new_pos)
		{
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00015014 File Offset: 0x00013214
		[Token(Token = "0x6001DF9")]
		public KeyValuePair<T, double> FindNearestInRadius(Vector3d query_pt, double radius, Func<T, double> distF, [Optional] Func<T, bool> ignoreF)
		{
			return default(KeyValuePair<T, double>);
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DFA")]
		private void insert_point(T value, Vector3i idx, bool threadsafe = true)
		{
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0001502C File Offset: 0x0001322C
		[Token(Token = "0x6001DFB")]
		private bool remove_point(T value, Vector3i idx, bool threadsafe = true)
		{
			return default(bool);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DFC")]
		public void print_large_buckets()
		{
		}

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<Vector3i, List<T>> Hash;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ScaleGridIndexer3 Indexer;

		// Token: 0x04001056 RID: 4182
		[Token(Token = "0x4001056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T invalidValue;

		// Token: 0x04001057 RID: 4183
		[Token(Token = "0x4001057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SpinLock spinlock;
	}
}
