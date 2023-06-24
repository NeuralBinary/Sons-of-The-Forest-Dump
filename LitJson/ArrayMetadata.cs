using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal struct ArrayMetadata
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public Type ElementType
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2089C20", Offset = "0x2088220", VA = "0x182089C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x8EC100", Offset = "0x8EA700", VA = "0x1808EC100")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		public bool IsArray
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xF9E8C0", Offset = "0xF9CEC0", VA = "0x180F9E8C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x2089CB0", Offset = "0x20882B0", VA = "0x182089CB0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002414 File Offset: 0x00000614
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002B")]
		public bool IsList
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x2089CC0", Offset = "0x20882C0", VA = "0x182089CC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x2089CD0", Offset = "0x20882D0", VA = "0x182089CD0")]
			set
			{
			}
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x0")]
		private Type element_type;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		private bool is_array;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x9")]
		private bool is_list;
	}
}
