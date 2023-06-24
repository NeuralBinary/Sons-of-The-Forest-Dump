using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	internal sealed class ResizableArray<T>
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x1700002D")]
		public int Length
		{
			[Token(Token = "0x6000225")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x1700002E")]
		public T[] Data
		{
			[Token(Token = "0x6000226")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		[Token(Token = "0x1700002F")]
		public T this[int index]
		{
			[Token(Token = "0x6000227")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		public ResizableArray(int capacity)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		public ResizableArray(int capacity, int length)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		public ResizableArray(T[] initialArray)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		private void IncreaseCapacity(int capacity)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		public void Clear()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		public void Resize(int length, bool trimExess = false, bool clearMemory = false)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		public void TrimExcess()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		public void Add(T item)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000231")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x0")]
		private T[] items;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x0")]
		private int length;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		private static T[] emptyArr;
	}
}
