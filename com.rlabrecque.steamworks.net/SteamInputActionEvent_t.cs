using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[Serializable]
	public struct SteamInputActionEvent_t
	{
		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputHandle_t controllerHandle;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ESteamInputActionEventType eEventType;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SteamInputActionEvent_t.OptionValue m_val;

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x20001C2")]
		[Serializable]
		public struct AnalogAction_t
		{
			// Token: 0x04000A94 RID: 2708
			[Token(Token = "0x4000A94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputAnalogActionHandle_t actionHandle;

			// Token: 0x04000A95 RID: 2709
			[Token(Token = "0x4000A95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputAnalogActionData_t analogActionData;
		}

		// Token: 0x020001C3 RID: 451
		[Token(Token = "0x20001C3")]
		[Serializable]
		public struct DigitalAction_t
		{
			// Token: 0x04000A96 RID: 2710
			[Token(Token = "0x4000A96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InputDigitalActionHandle_t actionHandle;

			// Token: 0x04000A97 RID: 2711
			[Token(Token = "0x4000A97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InputDigitalActionData_t digitalActionData;
		}

		// Token: 0x020001C4 RID: 452
		[Token(Token = "0x20001C4")]
		[Serializable]
		[StructLayout(2)]
		public struct OptionValue
		{
			// Token: 0x04000A98 RID: 2712
			[Token(Token = "0x4000A98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SteamInputActionEvent_t.AnalogAction_t analogAction;

			// Token: 0x04000A99 RID: 2713
			[Token(Token = "0x4000A99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SteamInputActionEvent_t.DigitalAction_t digitalAction;
		}
	}
}
