using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using TriangleNet.Topology;

namespace TriangleNet
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class TrianglePool : ICollection<Triangle>, IEnumerable<Triangle>, IEnumerable
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x24A8020", Offset = "0x24A6620", VA = "0x1824A8020")]
		public TrianglePool()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x24A8200", Offset = "0x24A6800", VA = "0x1824A8200")]
		public Triangle Get()
		{
			return null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x24A84B0", Offset = "0x24A6AB0", VA = "0x1824A84B0")]
		public void Release(Triangle triangle)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x24A8510", Offset = "0x24A6B10", VA = "0x1824A8510")]
		public TrianglePool Restart()
		{
			return null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x24A86E0", Offset = "0x24A6CE0", VA = "0x1824A86E0")]
		internal IEnumerable<Triangle> Sample(int k, Random random)
		{
			return null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x24A8800", Offset = "0x24A6E00", VA = "0x1824A8800")]
		private void Cleanup(Triangle triangle)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x24A88F0", Offset = "0x24A6EF0", VA = "0x1824A88F0", Slot = "6")]
		public void Add(Triangle item)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x24A8930", Offset = "0x24A6F30", VA = "0x1824A8930", Slot = "7")]
		public void Clear()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x24A8A50", Offset = "0x24A7050", VA = "0x1824A8A50", Slot = "8")]
		public bool Contains(Triangle item)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x24A8AD0", Offset = "0x24A70D0", VA = "0x1824A8AD0", Slot = "9")]
		public void CopyTo(Triangle[] array, int index)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000022")]
		public int Count
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x24A8D60", Offset = "0x24A7360", VA = "0x1824A8D60", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000023")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x24A8DA0", Offset = "0x24A73A0", VA = "0x1824A8DA0", Slot = "10")]
		public bool Remove(Triangle item)
		{
			return default(bool);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x24A8DE0", Offset = "0x24A73E0", VA = "0x1824A8DE0", Slot = "11")]
		public IEnumerator<Triangle> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x24A8EC0", Offset = "0x24A74C0", VA = "0x1824A8EC0", Slot = "12")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		private const int BLOCKSIZE = 1024;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x10")]
		private int size;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x14")]
		private int count;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x18")]
		private Triangle[][] pool;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x20")]
		private Stack<Triangle> stack;

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		private class Enumerator : IEnumerator<Triangle>, IEnumerator, IDisposable
		{
			// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x24A8ED0", Offset = "0x24A74D0", VA = "0x1824A8ED0")]
			public Enumerator(TrianglePool pool)
			{
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000EC RID: 236 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000024")]
			public Triangle Current
			{
				[Token(Token = "0x60000EC")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000EE RID: 238 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000025")]
			private object Current
			{
				[Token(Token = "0x60000EE")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00002688 File Offset: 0x00000888
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x24A8F80", Offset = "0x24A7580", VA = "0x1824A8F80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x24A9070", Offset = "0x24A7670", VA = "0x1824A9070", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x040001EF RID: 495
			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x10")]
			private int count;

			// Token: 0x040001F0 RID: 496
			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x18")]
			private Triangle[][] pool;

			// Token: 0x040001F1 RID: 497
			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x20")]
			private Triangle current;

			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x28")]
			private int index;

			// Token: 0x040001F3 RID: 499
			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x2C")]
			private int offset;
		}
	}
}
