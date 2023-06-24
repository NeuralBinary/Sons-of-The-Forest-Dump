using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	[NullableContext(1)]
	[Nullable(0)]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00006DC8 File Offset: 0x00004FC8
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		public DateTimeStyles DateTimeStyles
		{
			[Token(Token = "0x6000ECB")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return DateTimeStyles.None;
			}
			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			set
			{
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024E")]
		[Nullable(2)]
		public string DateTimeFormat
		{
			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x25F5B10", Offset = "0x25F4110", VA = "0x1825F5B10")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x25F5B60", Offset = "0x25F4160", VA = "0x1825F5B60")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x25F5BE0", Offset = "0x25F41E0", VA = "0x1825F5BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x25F5C70", Offset = "0x25F4270", VA = "0x1825F5C70", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x25F5F20", Offset = "0x25F4520", VA = "0x1825F5F20", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x25F6450", Offset = "0x25F4A50", VA = "0x1825F6450")]
		public IsoDateTimeConverter()
		{
		}

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x10")]
		private DateTimeStyles _dateTimeStyles;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(2)]
		private string _dateTimeFormat;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(2)]
		private CultureInfo _culture;
	}
}
