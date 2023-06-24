using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public struct Bits32
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002508 File Offset: 0x00000708
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public uint RawValue
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
			set
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
		public Bits32(uint bits = 0U)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x23AB6D0", Offset = "0x23A9CD0", VA = "0x1823AB6D0")]
		public void SetAllBits()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1DE25C0", Offset = "0x1DE0BC0", VA = "0x181DE25C0")]
		public void ClearAllBits()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1F43340", Offset = "0x1F41940", VA = "0x181F43340")]
		public void AssignBit(int index, bool value)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x23AB6E0", Offset = "0x23A9CE0", VA = "0x1823AB6E0")]
		public void SetBit(int index)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x23AB6F0", Offset = "0x23A9CF0", VA = "0x1823AB6F0")]
		public void ClearBit(int index)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1F43320", Offset = "0x1F41920", VA = "0x181F43320")]
		public bool IsBitSet(int index)
		{
			return default(bool);
		}

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private uint m_bits;
	}
}
