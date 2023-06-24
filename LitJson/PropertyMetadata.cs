using System;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	internal struct PropertyMetadata
	{
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
