using System;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00007338 File Offset: 0x00005538
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0x1E53120", Offset = "0x1E51720", VA = "0x181E53120")]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6001029")]
			[Address(RVA = "0x260D650", Offset = "0x260BC50", VA = "0x18260D650")]
			set
			{
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x260D670", Offset = "0x260BC70", VA = "0x18260D670")]
		public BsonWriter(Stream stream)
		{
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x260D830", Offset = "0x260BE30", VA = "0x18260D830")]
		public BsonWriter(BinaryWriter writer)
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102C")]
		[Address(RVA = "0x260D9C0", Offset = "0x260BFC0", VA = "0x18260D9C0", Slot = "66")]
		public override void Flush()
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102D")]
		[Address(RVA = "0x260DA00", Offset = "0x260C000", VA = "0x18260DA00", Slot = "78")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102E")]
		[Address(RVA = "0x260DAE0", Offset = "0x260C0E0", VA = "0x18260DAE0", Slot = "124")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102F")]
		[Address(RVA = "0x260DB30", Offset = "0x260C130", VA = "0x18260DB30", Slot = "72")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x260DB80", Offset = "0x260C180", VA = "0x18260DB80", Slot = "84")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x260DBD0", Offset = "0x260C1D0", VA = "0x18260DBD0", Slot = "85")]
		public override void WriteRawValue(string json)
		{
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x260DC20", Offset = "0x260C220", VA = "0x18260DC20", Slot = "70")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x260DD30", Offset = "0x260C330", VA = "0x18260DD30", Slot = "68")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x260DE40", Offset = "0x260C440", VA = "0x18260DE40", Slot = "74")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x260DF20", Offset = "0x260C520", VA = "0x18260DF20", Slot = "67")]
		public override void Close()
		{
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x260DF70", Offset = "0x260C570", VA = "0x18260DF70")]
		private void AddParent(BsonToken container)
		{
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x260DFE0", Offset = "0x260C5E0", VA = "0x18260DFE0")]
		private void RemoveParent()
		{
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001038")]
		[Address(RVA = "0x260E050", Offset = "0x260C650", VA = "0x18260E050")]
		private void AddValue(object value, BsonType type)
		{
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001039")]
		[Address(RVA = "0x260E110", Offset = "0x260C710", VA = "0x18260E110")]
		internal void AddToken(BsonToken token)
		{
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103A")]
		[Address(RVA = "0x260E4B0", Offset = "0x260CAB0", VA = "0x18260E4B0", Slot = "123")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103B")]
		[Address(RVA = "0x260E650", Offset = "0x260CC50", VA = "0x18260E650", Slot = "82")]
		public override void WriteNull()
		{
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103C")]
		[Address(RVA = "0x260E6D0", Offset = "0x260CCD0", VA = "0x18260E6D0", Slot = "83")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103D")]
		[Address(RVA = "0x260E750", Offset = "0x260CD50", VA = "0x18260E750", Slot = "86")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103E")]
		[Address(RVA = "0x260E850", Offset = "0x260CE50", VA = "0x18260E850", Slot = "87")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600103F")]
		[Address(RVA = "0x260E8D0", Offset = "0x260CED0", VA = "0x18260E8D0", Slot = "88")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001040")]
		[Address(RVA = "0x260E990", Offset = "0x260CF90", VA = "0x18260E990", Slot = "89")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001041")]
		[Address(RVA = "0x260EA10", Offset = "0x260D010", VA = "0x18260EA10", Slot = "90")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x260EAD0", Offset = "0x260D0D0", VA = "0x18260EAD0", Slot = "91")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x260EB50", Offset = "0x260D150", VA = "0x18260EB50", Slot = "92")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x260EBD0", Offset = "0x260D1D0", VA = "0x18260EBD0", Slot = "93")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x260EC80", Offset = "0x260D280", VA = "0x18260EC80", Slot = "94")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x260ED00", Offset = "0x260D300", VA = "0x18260ED00", Slot = "95")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x260ED80", Offset = "0x260D380", VA = "0x18260ED80", Slot = "96")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x260EEF0", Offset = "0x260D4F0", VA = "0x18260EEF0", Slot = "97")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x260EF70", Offset = "0x260D570", VA = "0x18260EF70", Slot = "98")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x260EFF0", Offset = "0x260D5F0", VA = "0x18260EFF0", Slot = "99")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x260F070", Offset = "0x260D670", VA = "0x18260F070", Slot = "100")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x260F120", Offset = "0x260D720", VA = "0x18260F120", Slot = "101")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x260F1A0", Offset = "0x260D7A0", VA = "0x18260F1A0", Slot = "121")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x260F290", Offset = "0x260D890", VA = "0x18260F290", Slot = "102")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x260F370", Offset = "0x260D970", VA = "0x18260F370", Slot = "103")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x260F480", Offset = "0x260DA80", VA = "0x18260F480", Slot = "122")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x260F5E0", Offset = "0x260DBE0", VA = "0x18260F5E0")]
		public void WriteObjectId(byte[] value)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x260F6F0", Offset = "0x260DCF0", VA = "0x18260F6F0")]
		public void WriteRegex(string pattern, string options)
		{
		}

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x60")]
		private readonly BsonBinaryWriter _writer;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x68")]
		private BsonToken _root;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x70")]
		private BsonToken _parent;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x78")]
		private string _propertyName;
	}
}
