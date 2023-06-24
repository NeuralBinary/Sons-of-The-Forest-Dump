using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	[Nullable(0)]
	[NullableContext(2)]
	internal struct StringBuffer
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000040F8 File Offset: 0x000022F8
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DD")]
		public int Position
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xF9ACD0", Offset = "0xF992D0", VA = "0x180F9ACD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x227D940", Offset = "0x227BF40", VA = "0x18227D940")]
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x170000DE")]
		public bool IsEmpty
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x902DE0", Offset = "0x9013E0", VA = "0x180902DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x256FCA0", Offset = "0x256E2A0", VA = "0x18256FCA0")]
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x256FD70", Offset = "0x256E370", VA = "0x18256FD70")]
		[NullableContext(1)]
		private StringBuffer(char[] buffer)
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x256FDE0", Offset = "0x256E3E0", VA = "0x18256FDE0")]
		public void Append(IArrayPool<char> bufferPool, char value)
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x256FE40", Offset = "0x256E440", VA = "0x18256FE40")]
		[NullableContext(1)]
		public void Append([Nullable(2)] IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x256FEC0", Offset = "0x256E4C0", VA = "0x18256FEC0")]
		public void Clear(IArrayPool<char> bufferPool)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x256FF90", Offset = "0x256E590", VA = "0x18256FF90")]
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2570170", Offset = "0x256E770", VA = "0x182570170", Slot = "3")]
		[NullableContext(1)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x2570190", Offset = "0x256E790", VA = "0x182570190")]
		[NullableContext(1)]
		public string ToString(int start, int length)
		{
			return null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000DF")]
		public char[] InternalBuffer
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			get
			{
				return null;
			}
		}

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x0")]
		private char[] _buffer;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x8")]
		private int _position;
	}
}
