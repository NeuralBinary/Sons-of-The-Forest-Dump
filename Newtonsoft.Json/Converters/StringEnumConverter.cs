using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[NullableContext(1)]
	[Nullable(0)]
	public class StringEnumConverter : JsonConverter
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00006E40 File Offset: 0x00005040
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
		public bool CamelCaseText
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x25F8A10", Offset = "0x25F7010", VA = "0x1825F8A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x25F8A80", Offset = "0x25F7080", VA = "0x1825F8A80")]
			set
			{
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000251")]
		[Nullable(2)]
		public NamingStrategy NamingStrategy
		{
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00006E58 File Offset: 0x00005058
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000252")]
		public bool AllowIntegerValues
		{
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x1487590", Offset = "0x1485B90", VA = "0x181487590")]
		public StringEnumConverter()
		{
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x25F8B40", Offset = "0x25F7140", VA = "0x1825F8B40")]
		[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
		public StringEnumConverter(bool camelCaseText)
		{
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x25F8BE0", Offset = "0x25F71E0", VA = "0x1825F8BE0")]
		public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x25F8C40", Offset = "0x25F7240", VA = "0x1825F8C40")]
		public StringEnumConverter(Type namingStrategyType)
		{
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x25F8D40", Offset = "0x25F7340", VA = "0x1825F8D40")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
		{
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x25F8E60", Offset = "0x25F7460", VA = "0x1825F8E60")]
		public StringEnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF3")]
		[Address(RVA = "0x25F8F90", Offset = "0x25F7590", VA = "0x1825F8F90", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EF4")]
		[Address(RVA = "0x25F91A0", Offset = "0x25F77A0", VA = "0x1825F91A0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x6000EF5")]
		[Address(RVA = "0x25F9610", Offset = "0x25F7C10", VA = "0x1825F9610", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}
	}
}
