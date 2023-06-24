using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Wearable.Clothing;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000796 RID: 1942
	[Token(Token = "0x2000796")]
	[AddComponentMenu("Sons/Pickup/ClothingPickUp")]
	public class ClothingPickUp : PickUp
	{
		// Token: 0x06003444 RID: 13380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003444")]
		[Address(RVA = "0x34C86E0", Offset = "0x34C6CE0", VA = "0x1834C86E0", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x34C8780", Offset = "0x34C6D80", VA = "0x1834C8780", Slot = "27")]
		protected override void Collect()
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x34C8830", Offset = "0x34C6E30", VA = "0x1834C8830", Slot = "29")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x6003447")]
		[Address(RVA = "0x34C8A20", Offset = "0x34C7020", VA = "0x1834C8A20")]
		private bool TryWearClothing()
		{
			return default(bool);
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003448")]
		[Address(RVA = "0x34C8B10", Offset = "0x34C7110", VA = "0x1834C8B10")]
		private IEnumerator WearClothingRoutine()
		{
			return null;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003449")]
		[Address(RVA = "0x34C8BA0", Offset = "0x34C71A0", VA = "0x1834C8BA0")]
		private IEnumerator WaitForAnimationStart()
		{
			return null;
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344A")]
		[Address(RVA = "0x34C8BE0", Offset = "0x34C71E0", VA = "0x1834C8BE0")]
		private IEnumerator WaitForAnimationEnd()
		{
			return null;
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344B")]
		[Address(RVA = "0x34C8C20", Offset = "0x34C7220", VA = "0x1834C8C20")]
		private IEnumerator WaitForIdle()
		{
			return null;
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344C")]
		[Address(RVA = "0x34C8C60", Offset = "0x34C7260", VA = "0x1834C8C60")]
		public void OnInterrupted()
		{
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344D")]
		[Address(RVA = "0x34C8CF0", Offset = "0x34C72F0", VA = "0x1834C8CF0")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600344E")]
		[Address(RVA = "0x34C8FE0", Offset = "0x34C75E0", VA = "0x1834C8FE0")]
		private static IEnumerator FadeOutLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600344F")]
		[Address(RVA = "0x34C9040", Offset = "0x34C7640", VA = "0x1834C9040", Slot = "21")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003450")]
		[Address(RVA = "0x34C7ED0", Offset = "0x34C64D0", VA = "0x1834C7ED0")]
		public ClothingPickUp()
		{
		}

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x108")]
		[EventRef]
		[SerializeField]
		private string _putOnAudioEvent;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x110")]
		private PlayerClothingSystem _playerClothingSystem;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x118")]
		private bool _secondaryHoldInputMethodIsActive;
	}
}
