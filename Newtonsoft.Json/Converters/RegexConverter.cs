using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	[NullableContext(1)]
	[Nullable(0)]
	public class RegexConverter : JsonConverter
	{
		// Token: 0x06000EDD RID: 3805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x25F7A40", Offset = "0x25F6040", VA = "0x1825F7A40", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return default(bool);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x25F7D30", Offset = "0x25F6330", VA = "0x1825F7D30")]
		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x25F7F50", Offset = "0x25F6550", VA = "0x1825F7F50")]
		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x25F8140", Offset = "0x25F6740", VA = "0x1825F8140", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x25F8340", Offset = "0x25F6940", VA = "0x1825F8340")]
		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EE3")]
		[Address(RVA = "0x25F84B0", Offset = "0x25F6AB0", VA = "0x1825F84B0")]
		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x25F88A0", Offset = "0x25F6EA0", VA = "0x1825F88A0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x25F8950", Offset = "0x25F6F50", VA = "0x1825F8950")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsRegex(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RegexConverter()
		{
		}

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		private const string PatternName = "Pattern";

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		private const string OptionsName = "Options";
	}
}
