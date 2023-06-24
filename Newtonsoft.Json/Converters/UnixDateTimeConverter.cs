using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	[Nullable(0)]
	[NullableContext(1)]
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00006E88 File Offset: 0x00005088
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public bool AllowPreEpoch
		{
			[Token(Token = "0x6000EF6")]
			[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x20A0A60", Offset = "0x209F060", VA = "0x1820A0A60")]
		public UnixDateTimeConverter()
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
		public UnixDateTimeConverter(bool allowPreEpoch)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x25F9690", Offset = "0x25F7C90", VA = "0x1825F9690", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x25F9A80", Offset = "0x25F8080", VA = "0x1825F9A80", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime UnixEpoch;
	}
}
