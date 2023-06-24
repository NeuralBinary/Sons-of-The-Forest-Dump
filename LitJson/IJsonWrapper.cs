using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000001")]
		bool IsArray { [Token(Token = "0x6000003")] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4
		[Token(Token = "0x17000002")]
		bool IsBoolean { [Token(Token = "0x6000004")] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5
		[Token(Token = "0x17000003")]
		bool IsDouble { [Token(Token = "0x6000005")] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000004")]
		bool IsInt { [Token(Token = "0x6000006")] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7
		[Token(Token = "0x17000005")]
		bool IsLong { [Token(Token = "0x6000007")] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		[Token(Token = "0x17000006")]
		bool IsObject { [Token(Token = "0x6000008")] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9
		[Token(Token = "0x17000007")]
		bool IsString { [Token(Token = "0x6000009")] get; }

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		bool GetBoolean();

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		double GetDouble();

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		int GetInt();

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		JsonType GetJsonType();

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		long GetLong();

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		string GetString();

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		void SetBoolean(bool val);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		void SetDouble(double val);

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		void SetInt(int val);

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		void SetJsonType(JsonType type);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		void SetLong(long val);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		void SetString(string val);

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		string ToJson();

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		void ToJson(JsonWriter writer);
	}
}
