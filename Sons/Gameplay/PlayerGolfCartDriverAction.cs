using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay
{
	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	[AddComponentMenu("Sons/Gameplay/PlayerGolfCartDriverAction")]
	public class PlayerGolfCartDriverAction : PlayerGolfCartAction
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x3555B50", Offset = "0x3554150", VA = "0x183555B50", Slot = "7")]
		protected override void UpdateInput()
		{
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x3555E60", Offset = "0x3554460", VA = "0x183555E60")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x35560A0", Offset = "0x35546A0", VA = "0x1835560A0", Slot = "8")]
		protected override void PostInitialize(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x35568C0", Offset = "0x3554EC0", VA = "0x1835568C0", Slot = "10")]
		protected override void DisconnectPlayerHook(GolfCartController golfCartController)
		{
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x3557280", Offset = "0x3555880", VA = "0x183557280")]
		private void StopDriverIkConnectCoroutine()
		{
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x35572F0", Offset = "0x35558F0", VA = "0x1835572F0", Slot = "9")]
		protected override void TriggerDisconnect()
		{
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x3557340", Offset = "0x3555940", VA = "0x183557340", Slot = "11")]
		protected override void ConnectIk(GolfCartController golfCartController)
		{
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x35574B0", Offset = "0x3555AB0", VA = "0x1835574B0")]
		private IEnumerator DelayedConnectIk(GolfCartController golfCartController)
		{
			return null;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x35575B0", Offset = "0x3555BB0", VA = "0x1835575B0", Slot = "12")]
		protected override void DisconnectIk(GolfCartController golfCartController)
		{
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x3557610", Offset = "0x3555C10", VA = "0x183557610")]
		private void OnTurnPerformed(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x3557690", Offset = "0x3555C90", VA = "0x183557690")]
		private void OnReversePerformed(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x3557700", Offset = "0x3555D00", VA = "0x183557700")]
		private void OnThrottleAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x3557770", Offset = "0x3555D70", VA = "0x183557770")]
		private bool GetHandBrakeInput()
		{
			return default(bool);
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x3557880", Offset = "0x3555E80", VA = "0x183557880")]
		private bool GetBoostInput()
		{
			return default(bool);
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x3557990", Offset = "0x3555F90", VA = "0x183557990")]
		private static Vector2 GetMovementInput()
		{
			return default(Vector2);
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x3557C80", Offset = "0x3556280", VA = "0x183557C80")]
		public PlayerGolfCartDriverAction()
		{
		}

		// Token: 0x04003149 RID: 12617
		[Token(Token = "0x4003149")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _driverConnectIkCoroutine;
	}
}
