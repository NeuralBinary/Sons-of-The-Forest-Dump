using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Conditional("UNITY_EDITOR")]
	public sealed class DictionaryDrawerSettings : Attribute
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A88520", Offset = "0x2A86B20", VA = "0x182A88520")]
		public DictionaryDrawerSettings()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		public string KeyLabel;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x18")]
		public string ValueLabel;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x20")]
		public DictionaryDisplayOptions DisplayMode;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x24")]
		public bool IsReadOnly;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		public float KeyColumnWidth;
	}
}
