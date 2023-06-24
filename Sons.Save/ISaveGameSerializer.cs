using System;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public interface ISaveGameSerializer<T>
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17
		[Token(Token = "0x17000005")]
		string SerializedName { [Token(Token = "0x6000011")] get; }

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		T OnSerialize();

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		void OnDeserialize(T data);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20
		[Token(Token = "0x17000006")]
		bool UniqueFile { [Token(Token = "0x6000014")] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21
		[Token(Token = "0x17000007")]
		bool ShouldSerialize { [Token(Token = "0x6000015")] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22
		[Token(Token = "0x17000008")]
		bool IncludeInPlayerSave { [Token(Token = "0x6000016")] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000009")]
		Func<string, T> DeserializeOverrideAction
		{
			[Token(Token = "0x6000017")]
			get
			{
				return null;
			}
		}
	}
}
