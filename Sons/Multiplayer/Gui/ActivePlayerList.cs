using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055A RID: 1370
	[Token(Token = "0x200055A")]
	[AddComponentMenu("Sons/Multiplayer/Gui/ActivePlayerList")]
	public class ActivePlayerList : PlayerListBase
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		public int PlayerCount
		{
			[Token(Token = "0x6002451")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002452")]
			[Address(RVA = "0x233AD40", Offset = "0x2339340", VA = "0x18233AD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DA")]
		public int PlayerLimit
		{
			[Token(Token = "0x6002453")]
			[Address(RVA = "0x245D8C0", Offset = "0x245BEC0", VA = "0x18245D8C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002454")]
			[Address(RVA = "0x287A660", Offset = "0x2878C60", VA = "0x18287A660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x3385A80", Offset = "0x3384080", VA = "0x183385A80", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, bool isBanned, bool isGuest, bool isTrusted, bool isAdmin, bool isOwner, bool isHost, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x3385AD0", Offset = "0x33840D0", VA = "0x183385AD0", Slot = "5")]
		protected override Task RefreshList()
		{
			return null;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x3385C40", Offset = "0x3384240", VA = "0x183385C40")]
		private void ProcessPlayer(ulong steamId, NetworkArray_ProtocolToken steamIds, NetworkArray_Integer playerRoles, bool isRequesterAdmin, bool isRequesterOwner, bool isRequesterHost)
		{
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x3385EF0", Offset = "0x33844F0", VA = "0x183385EF0")]
		private PlayerRoles GetRole(ulong steamId, NetworkArray_ProtocolToken steamIds, NetworkArray_Integer playerRoles)
		{
			return PlayerRoles.Unknown;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x3386080", Offset = "0x3384680", VA = "0x183386080")]
		private static BoltConnection GetConnectionFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x33860D0", Offset = "0x33846D0", VA = "0x1833860D0")]
		private static BoltEntity GetEntityFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x3386120", Offset = "0x3384720", VA = "0x183386120")]
		private void SetPlayerCountAndLimit(int playerCount, int playerLimit)
		{
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x3386140", Offset = "0x3384740", VA = "0x183386140")]
		private void SetPlayerCount(int playerCount, bool refreshText = true)
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x3386150", Offset = "0x3384750", VA = "0x183386150")]
		private void SetPlayerLimit(int count, bool refreshText = true)
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x3386160", Offset = "0x3384760", VA = "0x183386160")]
		private void RefreshPlayerCountText()
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x3386480", Offset = "0x3384A80", VA = "0x183386480")]
		public ActivePlayerList()
		{
		}

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LocalizeStringEvent[] _playerCountText;
	}
}
