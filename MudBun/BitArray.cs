using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class BitArray
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x23AAF50", Offset = "0x23A9550", VA = "0x1823AAF50")]
		public static int ComputeNumInts(int numBits)
		{
			return 0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x23AAFB0", Offset = "0x23A95B0", VA = "0x1823AAFB0")]
		public BitArray(int capacity = 512)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x23AB100", Offset = "0x23A9700", VA = "0x1823AB100")]
		public void SetAll()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x23AB160", Offset = "0x23A9760", VA = "0x1823AB160")]
		public void ClearAll()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x23AB1C0", Offset = "0x23A97C0", VA = "0x1823AB1C0")]
		public void Set(int bit)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x23AB260", Offset = "0x23A9860", VA = "0x1823AB260")]
		public void Clear(int bit)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x23AB300", Offset = "0x23A9900", VA = "0x1823AB300")]
		public bool Get(int bit)
		{
			return default(bool);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public int Capacity
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x23AB3A0", Offset = "0x23A99A0", VA = "0x1823AB3A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x23AB410", Offset = "0x23A9A10", VA = "0x1823AB410")]
			set
			{
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x23AB540", Offset = "0x23A9B40", VA = "0x1823AB540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BitsPerInt;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10")]
		private int[] m_aInt;
	}
}
