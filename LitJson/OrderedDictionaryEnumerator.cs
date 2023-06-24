using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000025")]
		public object Current
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x2089380", Offset = "0x2087980", VA = "0x182089380", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x17000026")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x2089560", Offset = "0x2087B60", VA = "0x182089560", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000027")]
		public object Key
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2089660", Offset = "0x2087C60", VA = "0x182089660", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000028")]
		public object Value
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x2089720", Offset = "0x2087D20", VA = "0x182089720", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x20897F0", Offset = "0x2087DF0", VA = "0x1820897F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2089840", Offset = "0x2087E40", VA = "0x182089840", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;
	}
}
