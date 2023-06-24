using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public struct ValueDropdownItem<T> : IValueDropdownItem
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013F")]
		public ValueDropdownItem(string text, T value)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000140")]
		private string GetText()
		{
			return null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000141")]
		private object GetValue()
		{
			return null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000142")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
