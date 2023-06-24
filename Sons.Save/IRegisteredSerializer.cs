using System;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal interface IRegisteredSerializer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5
		[Token(Token = "0x17000001")]
		string Name { [Token(Token = "0x6000005")] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000002")]
		bool UniqueFile { [Token(Token = "0x6000006")] get; }

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		bool Is(object serializer);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		object Serialize();

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void Deserialize(string json);

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		object GetData(string json);

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		bool IsType(Type type);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		bool IsSerializedType(Type type);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13
		[Token(Token = "0x17000003")]
		bool ShouldSerialize { [Token(Token = "0x600000D")] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14
		[Token(Token = "0x17000004")]
		bool IncludeInPlayerSave { [Token(Token = "0x600000E")] get; }
	}
}
