using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[NullableContext(1)]
	[Nullable(0)]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F6")]
		[Nullable(2)]
		public object CurrentObject
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F7")]
		public ErrorContext ErrorContext
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x257E970", Offset = "0x257CF70", VA = "0x18257E970")]
		public ErrorEventArgs([Nullable(2)] object currentObject, ErrorContext errorContext)
		{
		}
	}
}
