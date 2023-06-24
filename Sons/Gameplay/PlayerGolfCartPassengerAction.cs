using System;
using Endnight.Animation;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000819 RID: 2073
	[Token(Token = "0x2000819")]
	[AddComponentMenu("Sons/Gameplay/PlayerGolfCartPassengerAction")]
	public class PlayerGolfCartPassengerAction : PlayerGolfCartAction, ILastUpdateProxyReceiver
	{
		// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x3557F20", Offset = "0x3556520", VA = "0x183557F20")]
		private void OnEnable()
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x1700076C")]
		public int LastUpdatePriority
		{
			[Token(Token = "0x600398B")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x3557F30", Offset = "0x3556530", VA = "0x183557F30", Slot = "13")]
		public void LastUpdate()
		{
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398D")]
		[Address(RVA = "0x3557FD0", Offset = "0x35565D0", VA = "0x183557FD0", Slot = "8")]
		protected override void PostInitialize(GolfCartController golfCartController)
		{
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x35587F0", Offset = "0x3556DF0", VA = "0x1835587F0", Slot = "10")]
		protected override void DisconnectPlayerHook(GolfCartController golfCartController)
		{
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x35591A0", Offset = "0x35577A0", VA = "0x1835591A0", Slot = "9")]
		protected override void TriggerDisconnect()
		{
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x3557C80", Offset = "0x3556280", VA = "0x183557C80")]
		public PlayerGolfCartPassengerAction()
		{
		}
	}
}
