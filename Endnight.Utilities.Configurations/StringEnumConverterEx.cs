using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Endnight.Utilities.Configurations
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class StringEnumConverterEx<T> : StringEnumConverter
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		private T DefaultValue
		{
			[Token(Token = "0x6000014")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000015")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		public StringEnumConverterEx()
		{
		}
	}
}
