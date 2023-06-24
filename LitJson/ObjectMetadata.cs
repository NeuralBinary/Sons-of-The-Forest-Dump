using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	internal struct ObjectMetadata
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002C")]
		public Type ElementType
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x2089CE0", Offset = "0x20882E0", VA = "0x182089CE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000242C File Offset: 0x0000062C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public bool IsDictionary
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xF9E8C0", Offset = "0xF9CEC0", VA = "0x180F9E8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2089CB0", Offset = "0x20882B0", VA = "0x182089CB0")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;
	}
}
