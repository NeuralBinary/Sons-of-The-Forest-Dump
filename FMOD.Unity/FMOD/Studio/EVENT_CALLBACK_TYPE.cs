using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		CREATED = 1U,
		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		DESTROYED = 2U,
		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		STARTING = 4U,
		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		STARTED = 8U,
		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		RESTARTED = 16U,
		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		STOPPED = 32U,
		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		START_FAILED = 64U,
		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		CREATE_PROGRAMMER_SOUND = 128U,
		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		DESTROY_PROGRAMMER_SOUND = 256U,
		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		PLUGIN_CREATED = 512U,
		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		PLUGIN_DESTROYED = 1024U,
		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		TIMELINE_MARKER = 2048U,
		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		TIMELINE_BEAT = 4096U,
		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		SOUND_PLAYED = 8192U,
		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		SOUND_STOPPED = 16384U,
		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		REAL_TO_VIRTUAL = 32768U,
		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		VIRTUAL_TO_REAL = 65536U,
		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		ALL = 4294967295U
	}
}
