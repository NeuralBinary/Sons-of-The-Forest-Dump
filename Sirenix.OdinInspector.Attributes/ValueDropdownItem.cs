using System;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	public struct ValueDropdownItem : IValueDropdownItem
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5F84C0", Offset = "0x5F6AC0", VA = "0x1805F84C0")]
		public ValueDropdownItem(string text, object value)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2A8AB00", Offset = "0x2A89100", VA = "0x182A8AB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x633720", Offset = "0x631D20", VA = "0x180633720", Slot = "4")]
		private string GetText()
		{
			return null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9C2AC0", Offset = "0x9C10C0", VA = "0x1809C2AC0", Slot = "5")]
		private object GetValue()
		{
			return null;
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x0")]
		public string Text;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x8")]
		public object Value;
	}
}
