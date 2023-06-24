using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public struct NativeMultilevelGrid<T> : IDisposable where T : struct, IEquatable<T>
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003E5")]
		public NativeMultilevelGrid(int capacity, Allocator label)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00003944 File Offset: 0x00001B44
		[Token(Token = "0x17000079")]
		public int CellCount
		{
			[Token(Token = "0x60003E6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003E7")]
		public void Clear()
		{
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003E8")]
		public void Dispose()
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x60003E9")]
		public int GetOrCreateCell(int4 cellCoords)
		{
			return 0;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x60003EA")]
		public bool TryGetCellIndex(int4 cellCoords, out int cellIndex)
		{
			return default(bool);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003EB")]
		public void RemoveEmpty()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000398C File Offset: 0x00001B8C
		[Token(Token = "0x60003EC")]
		public static int GridLevelForSize(float size)
		{
			return 0;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000039A4 File Offset: 0x00001BA4
		[Token(Token = "0x60003ED")]
		public static float CellSizeOfLevel(int level)
		{
			return 0f;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x60003EE")]
		public static int4 GetParentCellCoords(int4 cellCoords, int level)
		{
			return default(int4);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003EF")]
		public void RemoveFromCells(BurstCellSpan span, T content)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003F0")]
		public void AddToCells(BurstCellSpan span, T content)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003F1")]
		public static void GetCellCoordsForBoundsAtLevel(NativeList<int4> coords, BurstAabb bounds, int level, int maxSize = 10)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003F2")]
		private void IncreaseLevelPopulation(int level)
		{
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003F3")]
		private void DecreaseLevelPopulation(int level)
		{
		}

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		public const float minSize = 0.01f;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x0")]
		public NativeHashMap<int4, int> grid;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x0")]
		public NativeList<NativeMultilevelGrid<T>.Cell<T>> usedCells;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x0")]
		public NativeHashMap<int, int> populatedLevels;

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		public struct Cell<K> where K : struct, IEquatable<K>
		{
			// Token: 0x060003F4 RID: 1012 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003F4")]
			public Cell(int4 coords)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000039D4 File Offset: 0x00001BD4
			[Token(Token = "0x1700007A")]
			public int4 Coords
			{
				[Token(Token = "0x60003F5")]
				get
				{
					return default(int4);
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000039EC File Offset: 0x00001BEC
			[Token(Token = "0x1700007B")]
			public int Length
			{
				[Token(Token = "0x60003F6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002186 File Offset: 0x00000386
			[Token(Token = "0x1700007C")]
			public unsafe void* ContentsPointer
			{
				[Token(Token = "0x60003F7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700007D RID: 125
			[Token(Token = "0x1700007D")]
			public K this[int index]
			{
				[Token(Token = "0x60003F8")]
				get
				{
					return null;
				}
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003F9")]
			public void Add(K entity)
			{
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00003A04 File Offset: 0x00001C04
			[Token(Token = "0x60003FA")]
			public bool Remove(K entity)
			{
				return default(bool);
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60003FB")]
			public void Destroy()
			{
			}

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			[FieldOffset(Offset = "0x0")]
			private int4 coords;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			[FieldOffset(Offset = "0x0")]
			private UnsafeList contents;
		}
	}
}
