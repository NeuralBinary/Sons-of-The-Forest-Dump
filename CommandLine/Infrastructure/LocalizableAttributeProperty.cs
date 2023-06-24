using System;
using System.Reflection;
using Il2CppDummyDll;

namespace CommandLine.Infrastructure
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	internal class LocalizableAttributeProperty
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public LocalizableAttributeProperty(string propertyName)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BF")]
		public string Value
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x9A22A0", Offset = "0x9A08A0", VA = "0x1809A22A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x9A22B0", Offset = "0x9A08B0", VA = "0x1809A22B0")]
			set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C0")]
		public Type ResourceType
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x9A2370", Offset = "0x9A0970", VA = "0x1809A2370")]
			set
			{
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9A2430", Offset = "0x9A0A30", VA = "0x1809A2430")]
		private string GetLocalizedValue()
		{
			return null;
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x10")]
		private string _propertyName;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x18")]
		private string _value;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x20")]
		private Type _type;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		private PropertyInfo _localizationPropertyInfo;
	}
}
