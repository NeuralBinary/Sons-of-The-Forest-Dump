using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	[Nullable(0)]
	[NullableContext(2)]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x25DB740", Offset = "0x25D9D40", VA = "0x1825DB740", Slot = "24")]
		[NullableContext(1)]
		internal override Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700022E")]
		public JToken CurrentToken
		{
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000D87 RID: 3463 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700022F")]
		public JToken Token
		{
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x25DB840", Offset = "0x25D9E40", VA = "0x1825DB840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x25DB850", Offset = "0x25D9E50", VA = "0x1825DB850")]
		[NullableContext(1)]
		public JTokenWriter(JContainer container)
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x25DB9C0", Offset = "0x25D9FC0", VA = "0x1825DB9C0")]
		public JTokenWriter()
		{
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "66")]
		public override void Flush()
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x25DBA20", Offset = "0x25DA020", VA = "0x1825DBA20", Slot = "67")]
		public override void Close()
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x25DBA30", Offset = "0x25DA030", VA = "0x1825DBA30", Slot = "68")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x25DBAC0", Offset = "0x25DA0C0", VA = "0x1825DBAC0")]
		[NullableContext(1)]
		private void AddParent(JContainer container)
		{
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x25DBC70", Offset = "0x25DA270", VA = "0x1825DBC70")]
		private void RemoveParent()
		{
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x25DBDC0", Offset = "0x25DA3C0", VA = "0x1825DBDC0", Slot = "70")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x25DBE50", Offset = "0x25DA450", VA = "0x1825DBE50", Slot = "72")]
		[NullableContext(1)]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x25DBC70", Offset = "0x25DA270", VA = "0x1825DBC70", Slot = "78")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x25DBEF0", Offset = "0x25DA4F0", VA = "0x1825DBEF0", Slot = "74")]
		[NullableContext(1)]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x25DC080", Offset = "0x25DA680", VA = "0x1825DC080")]
		private void AddRawValue(object value, JTokenType type, JsonToken token)
		{
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x25DC110", Offset = "0x25DA710", VA = "0x1825DC110")]
		internal void AddJValue(JValue value, JsonToken token)
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x25DC340", Offset = "0x25DA940", VA = "0x1825DC340", Slot = "123")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x25DC3E0", Offset = "0x25DA9E0", VA = "0x1825DC3E0", Slot = "82")]
		public override void WriteNull()
		{
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x25DC460", Offset = "0x25DAA60", VA = "0x1825DC460", Slot = "83")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x25DC4E0", Offset = "0x25DAAE0", VA = "0x1825DC4E0", Slot = "84")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x25DC560", Offset = "0x25DAB60", VA = "0x1825DC560", Slot = "124")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x25DC5E0", Offset = "0x25DABE0", VA = "0x1825DC5E0", Slot = "86")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x25DC670", Offset = "0x25DAC70", VA = "0x1825DC670", Slot = "87")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x25DC700", Offset = "0x25DAD00", VA = "0x1825DC700", Slot = "88")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x25DC790", Offset = "0x25DAD90", VA = "0x1825DC790", Slot = "89")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x25DC820", Offset = "0x25DAE20", VA = "0x1825DC820", Slot = "90")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x25DC8E0", Offset = "0x25DAEE0", VA = "0x1825DC8E0", Slot = "91")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x25DC9A0", Offset = "0x25DAFA0", VA = "0x1825DC9A0", Slot = "92")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x25DCA30", Offset = "0x25DB030", VA = "0x1825DCA30", Slot = "93")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x25DCAC0", Offset = "0x25DB0C0", VA = "0x1825DCAC0", Slot = "94")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x25DCB50", Offset = "0x25DB150", VA = "0x1825DCB50", Slot = "95")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x25DCBE0", Offset = "0x25DB1E0", VA = "0x1825DCBE0", Slot = "96")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x25DCD10", Offset = "0x25DB310", VA = "0x1825DCD10", Slot = "97")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x25DCDA0", Offset = "0x25DB3A0", VA = "0x1825DCDA0", Slot = "98")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x25DCE30", Offset = "0x25DB430", VA = "0x1825DCE30", Slot = "99")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x25DCF00", Offset = "0x25DB500", VA = "0x1825DCF00", Slot = "100")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x25DD000", Offset = "0x25DB600", VA = "0x1825DD000", Slot = "101")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x25DD0C0", Offset = "0x25DB6C0", VA = "0x1825DD0C0", Slot = "121")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x25DD170", Offset = "0x25DB770", VA = "0x1825DD170", Slot = "103")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x25DD230", Offset = "0x25DB830", VA = "0x1825DD230", Slot = "102")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x25DD2F0", Offset = "0x25DB8F0", VA = "0x1825DD2F0", Slot = "122")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x25DD3D0", Offset = "0x25DB9D0", VA = "0x1825DD3D0", Slot = "77")]
		[NullableContext(1)]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x60")]
		private JContainer _token;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x68")]
		private JContainer _parent;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x70")]
		private JValue _value;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x78")]
		private JToken _current;
	}
}
