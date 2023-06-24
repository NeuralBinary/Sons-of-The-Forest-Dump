using System;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	internal class RegisteredSerializer<T> : IRegisteredSerializer
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000A")]
		public string Name
		{
			[Token(Token = "0x6000018")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x1700000B")]
		public bool UniqueFile
		{
			[Token(Token = "0x6000019")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x1700000C")]
		public bool ShouldSerialize
		{
			[Token(Token = "0x600001A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x1700000D")]
		public bool IncludeInPlayerSave
		{
			[Token(Token = "0x600001B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600001C")]
		public bool Is(object serializer)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001D")]
		public object Serialize()
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		public void Deserialize(string json)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001F")]
		public object GetData(string json)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000020")]
		public bool IsType(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000021")]
		public bool IsSerializedType(Type type)
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		public RegisteredSerializer()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public ISaveGameSerializer<T> Serializer;
	}
}
