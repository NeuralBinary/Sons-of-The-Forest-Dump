using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Loading;
using Sons.Multiplayer.Dedicated;
using Steamworks;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class DedicatedGameInviteDialogController : DynamicModalDialogController
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000006")]
		private gameserveritem_t GameServer
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x30286C0", Offset = "0x3026CC0", VA = "0x1830286C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3028750", Offset = "0x3026D50", VA = "0x183028750", Slot = "4")]
		protected override DynamicModalDialogController.Options GetOptions()
		{
			return (DynamicModalDialogController.Options)0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x3028820", Offset = "0x3026E20", VA = "0x183028820", Slot = "5")]
		protected override void SetupLocalizedStringArguments()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x3028980", Offset = "0x3026F80", VA = "0x183028980", Slot = "7")]
		protected override void OnOption1()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3028A00", Offset = "0x3027000", VA = "0x183028A00", Slot = "8")]
		protected override void OnOption2()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3028A80", Offset = "0x3027080", VA = "0x183028A80", Slot = "9")]
		protected override void OnOption3()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3028B00", Offset = "0x3027100", VA = "0x183028B00")]
		private void CheckLobbyFull(Action onSuccess)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x3028C10", Offset = "0x3027210", VA = "0x183028C10")]
		private void SetAutoJoinAndLoad()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3007190", Offset = "0x3005790", VA = "0x183007190")]
		public DedicatedGameInviteDialogController()
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x3028FE0", Offset = "0x30275E0", VA = "0x183028FE0")]
		[CompilerGenerated]
		private void <OnOption2>g__OnNewSaveConfirmed|7_1()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("Dedicated Game Invite Dialog Properties")]
		private LoadScene _loadScene;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private DedicatedServerBrowser _dedicatedBrowser;
	}
}
