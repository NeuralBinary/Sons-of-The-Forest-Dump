using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	[NullableContext(1)]
	[Nullable(0)]
	internal readonly struct StringReference
	{
		// Token: 0x170000E0 RID: 224
		[Token(Token = "0x170000E0")]
		public char this[int i]
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x25701A0", Offset = "0x256E7A0", VA = "0x1825701A0")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000E1")]
		public char[] Chars
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x170000E2")]
		public int StartIndex
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xF9ACD0", Offset = "0xF992D0", VA = "0x180F9ACD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x170000E3")]
		public int Length
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xD96410", Offset = "0xD94A10", VA = "0x180D96410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x123B0E0", Offset = "0x12396E0", VA = "0x18123B0E0")]
		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x25701D0", Offset = "0x256E7D0", VA = "0x1825701D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _length;
	}
}
