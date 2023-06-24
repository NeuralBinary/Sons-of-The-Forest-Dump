using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Settings
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Serializable]
	public class PersistentValue
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000002")]
		[JsonIgnore]
		public bool IsBoolType
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x3131080", Offset = "0x312F680", VA = "0x183131080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x17000003")]
		[JsonIgnore]
		public bool IsIntType
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x3131090", Offset = "0x312F690", VA = "0x183131090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x17000004")]
		[JsonIgnore]
		public bool IsFloatType
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x31310A0", Offset = "0x312F6A0", VA = "0x1831310A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x17000005")]
		[JsonIgnore]
		public bool IsStringType
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x31310B0", Offset = "0x312F6B0", VA = "0x1831310B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x17000006")]
		[JsonIgnore]
		public bool IsFloatArrayType
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x31310C0", Offset = "0x312F6C0", VA = "0x1831310C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x31310D0", Offset = "0x312F6D0", VA = "0x1831310D0")]
		private void ClearEmptyFloatArray()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x31310D0", Offset = "0x312F6D0", VA = "0x1831310D0")]
		[OnDeserialized]
		internal void OnDeserializedMethod(StreamingContext context)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x31310D0", Offset = "0x312F6D0", VA = "0x1831310D0")]
		[OnSerializing]
		internal void OnSerializingMethod(StreamingContext context)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3131140", Offset = "0x312F740", VA = "0x183131140")]
		public bool Matches(string name)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3131210", Offset = "0x312F810", VA = "0x183131210")]
		public bool Matches(int nameKey)
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x31312A0", Offset = "0x312F8A0", VA = "0x1831312A0")]
		public PersistentValue Clone()
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x3131430", Offset = "0x312FA30", VA = "0x183131430")]
		public bool MatchesRegex(string regexString)
		{
			return default(bool);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3131490", Offset = "0x312FA90", VA = "0x183131490")]
		public PersistentValue()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty]
		[DefaultValue("")]
		public string Name;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		[DefaultValue(0)]
		public int NameKey;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty]
		[DefaultValue(SettingType.Bool)]
		public SettingType SettingType;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty]
		[DefaultValue(0)]
		public int Version;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x24")]
		[DefaultValue(false)]
		[JsonProperty]
		public bool BoolValue;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty]
		[DefaultValue(0)]
		public int IntValue;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x2C")]
		[DefaultValue(0f)]
		[JsonProperty]
		public float FloatValue;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x30")]
		[DefaultValue("")]
		[JsonProperty]
		public string StringValue;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		[DefaultValue(false)]
		[JsonProperty]
		public bool Protected;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		[DefaultValue(null)]
		[JsonProperty(NullValueHandling = 1)]
		public float[] FloatArrayValue;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		[DefaultValue(false)]
		[JsonProperty]
		public bool IsSet;
	}
}
