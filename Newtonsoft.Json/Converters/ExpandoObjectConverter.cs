using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	[NullableContext(1)]
	[Nullable(0)]
	public class ExpandoObjectConverter : JsonConverter
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x25F5380", Offset = "0x25F3980", VA = "0x1825F5380", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x25F5390", Offset = "0x25F3990", VA = "0x1825F5390")]
		private object ReadValue(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x25F5660", Offset = "0x25F3C60", VA = "0x1825F5660")]
		private object ReadList(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x25F5790", Offset = "0x25F3D90", VA = "0x1825F5790")]
		private object ReadObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x6000EC8")]
		[Address(RVA = "0x25F5A50", Offset = "0x25F4050", VA = "0x1825F5A50", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x1700024C")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ExpandoObjectConverter()
		{
		}
	}
}
