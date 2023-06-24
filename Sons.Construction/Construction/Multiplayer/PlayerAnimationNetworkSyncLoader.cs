using System;
using Bolt;
using Construction.Anim;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	[AddComponentMenu("Sons/Construction/PlayerAnimationNetworkSyncLoader")]
	public class PlayerAnimationNetworkSyncLoader : EntityBehaviour<IPlayerState>
	{
		// Token: 0x06001436 RID: 5174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x2DED7F0", Offset = "0x2DEBDF0", VA = "0x182DED7F0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001437")]
		[Address(RVA = "0x2DED830", Offset = "0x2DEBE30", VA = "0x182DED830")]
		private void CreateNetworkSyncEntity()
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x2DEDA80", Offset = "0x2DEC080", VA = "0x182DEDA80")]
		public PlayerAnimationNetworkSyncLoader()
		{
		}

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ConstructionManager _manager;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerBuildingModeAction _buildAction;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FreeFormPlayerNetworkAnimation _networkAnim;
	}
}
