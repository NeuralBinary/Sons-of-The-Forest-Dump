using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	public struct USER_PROPERTY
	{
		// Token: 0x060004D6 RID: 1238 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xB3F1F0", Offset = "0xB3D7F0", VA = "0x180B3F1F0")]
		public int intValue()
		{
			return 0;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xB3F200", Offset = "0xB3D800", VA = "0x180B3F200")]
		public bool boolValue()
		{
			return default(bool);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xB3F210", Offset = "0xB3D810", VA = "0x180B3F210")]
		public float floatValue()
		{
			return 0f;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xB3F230", Offset = "0xB3D830", VA = "0x180B3F230")]
		public string stringValue()
		{
			return null;
		}

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;
	}
}
