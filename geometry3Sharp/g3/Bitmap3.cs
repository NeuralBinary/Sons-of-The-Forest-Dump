using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000353 RID: 851
	[Token(Token = "0x2000353")]
	public class Bitmap3 : IBinaryVoxelGrid, IGridElement3, IFixedGrid3
	{
		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00013E5C File Offset: 0x0001205C
		[Token(Token = "0x17000435")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0", Slot = "8")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x1F66790", Offset = "0x1F64D90", VA = "0x181F66790")]
		public Bitmap3(Vector3i dims)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x00013E74 File Offset: 0x00012074
		[Token(Token = "0x17000436")]
		public AxisAlignedBox3i GridBounds
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x1F66880", Offset = "0x1F64E80", VA = "0x181F66880", Slot = "4")]
			get
			{
				return default(AxisAlignedBox3i);
			}
		}

		// Token: 0x17000437 RID: 1079
		[Token(Token = "0x17000437")]
		public bool this[int i]
		{
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0x1F66100", Offset = "0x1F64700", VA = "0x181F66100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x1F66120", Offset = "0x1F64720", VA = "0x181F66120")]
			set
			{
			}
		}

		// Token: 0x17000438 RID: 1080
		[Token(Token = "0x17000438")]
		public bool this[Vector3i idx]
		{
			[Token(Token = "0x6001C13")]
			[Address(RVA = "0x1F669B0", Offset = "0x1F64FB0", VA = "0x181F669B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C14")]
			[Address(RVA = "0x1F669F0", Offset = "0x1F64FF0", VA = "0x181F669F0")]
			set
			{
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x1F669F0", Offset = "0x1F64FF0", VA = "0x181F669F0")]
		public void Set(Vector3i idx, bool val)
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x1F66A30", Offset = "0x1F65030", VA = "0x181F66A30")]
		public void SafeSet(Vector3i idx, bool val)
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00013EBC File Offset: 0x000120BC
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x1F669B0", Offset = "0x1F64FB0", VA = "0x181F669B0", Slot = "5")]
		public bool Get(Vector3i idx)
		{
			return default(bool);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00013ED4 File Offset: 0x000120D4
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x1F66B10", Offset = "0x1F65110", VA = "0x181F66B10")]
		public Vector3i ToIndex(int i)
		{
			return default(Vector3i);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00013EEC File Offset: 0x000120EC
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x1F66B50", Offset = "0x1F65150", VA = "0x181F66B50")]
		public int ToLinear(Vector3i idx)
		{
			return 0;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x1F66B70", Offset = "0x1F65170", VA = "0x181F66B70")]
		public IEnumerable<Vector3i> Indices()
		{
			return null;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x1F66C10", Offset = "0x1F65210", VA = "0x181F66C10", Slot = "6")]
		public IEnumerable<Vector3i> NonZeros()
		{
			return null;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x1F66CB0", Offset = "0x1F652B0", VA = "0x181F66CB0")]
		public void Filter(int nMinNbrs)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x1F67020", Offset = "0x1F65620", VA = "0x181F67020", Slot = "9")]
		public virtual IGridElement3 CreateNewGridElement(bool bCopy)
		{
			return null;
		}

		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x10")]
		public BitArray Bits;

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x18")]
		private Vector3i dimensions;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x24")]
		private int row_size;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x28")]
		private int slab_size;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x2C")]
		private SpinLock bit_lock;
	}
}
