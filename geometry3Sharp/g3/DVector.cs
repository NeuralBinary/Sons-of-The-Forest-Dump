using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class DVector<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		public DVector()
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		public DVector(DVector<T> copy)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		public DVector(T[] data)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000210")]
		public DVector(IEnumerable<T> init)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x17000025")]
		public int Length
		{
			[Token(Token = "0x6000211")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x17000026")]
		public int BlockCount
		{
			[Token(Token = "0x6000212")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x17000027")]
		public int size
		{
			[Token(Token = "0x6000213")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x17000028")]
		public bool empty
		{
			[Token(Token = "0x6000214")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x17000029")]
		public int MemoryUsageBytes
		{
			[Token(Token = "0x6000215")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		public void Add(T value)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		public void Add(T value, int nRepeat)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		public void Add(T[] values)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		public void Add(T[] values, int nRepeat)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021A")]
		public void push_back(T value)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		public void pop_back()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		public void insert(T value, int index)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021D")]
		public void insertAt(T value, int index)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021E")]
		public void resize(int count)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021F")]
		public void copy(DVector<T> copyIn)
		{
		}

		// Token: 0x1700002A RID: 42
		[Token(Token = "0x1700002A")]
		public T this[int i]
		{
			[Token(Token = "0x6000220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000221")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public T back
		{
			[Token(Token = "0x6000222")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000223")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public T front
		{
			[Token(Token = "0x6000224")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000225")]
			set
			{
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000226")]
		public void GetBuffer(T[] data)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000227")]
		public T[] GetBuffer()
		{
			return null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000228")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000229")]
		public T2[] GetBufferCast<T2>()
		{
			return null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022A")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022B")]
		public void Initialize(T[] data)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022C")]
		public void Clear()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022D")]
		public void Apply(Action<T, int> applyF)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022E")]
		public void ApplyReplace(Func<T, int, T> applyF)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022F")]
		public unsafe static void FastGetBuffer(DVector<double> v, double* pBuffer)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000230")]
		public unsafe static void FastGetBuffer(DVector<float> v, float* pBuffer)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000231")]
		public unsafe static void FastGetBuffer(DVector<int> v, int* pBuffer)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000232")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000233")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000234")]
		public IEnumerable<DVector<T>.DBlock> BlockIterator()
		{
			return null;
		}

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x0")]
		private List<T[]> Blocks;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x0")]
		private int iCurBlock;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		private int iCurBlockUsed;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x0")]
		private int nBlockSize;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		private const int nShiftBits = 11;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		private const int nBlockIndexBitmask = 2047;

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		public struct DBlock
		{
			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x0")]
			public T[] data;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x0")]
			public int usedCount;
		}
	}
}
