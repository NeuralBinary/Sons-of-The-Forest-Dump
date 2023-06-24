using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000219 RID: 537
	[Token(Token = "0x2000219")]
	public class PlaceStackOnGroundModule : PlaceOnGroundModule
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00009BE4 File Offset: 0x00007DE4
		[Token(Token = "0x170003BC")]
		public override bool ConsumesProfileItem
		{
			[Token(Token = "0x6001013")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00009BFC File Offset: 0x00007DFC
		[Token(Token = "0x170003BD")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6001014")]
			[Address(RVA = "0x2F0A8C0", Offset = "0x2F08EC0", VA = "0x182F0A8C0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x2E2C400", Offset = "0x2E2AA00", VA = "0x182E2C400")]
		public PlaceStackOnGroundModule(ModuleProfileDatabase profileDb)
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x2F0A8D0", Offset = "0x2F08ED0", VA = "0x182F0A8D0", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}
	}
}
