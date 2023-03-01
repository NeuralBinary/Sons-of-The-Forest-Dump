using System;
using System.Collections;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Wearable.Clothing;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000675 RID: 1653
	[Token(Token = "0x2000675")]
	[AddComponentMenu("Sons/Pickup/ClothingPickUp")]
	public class ClothingPickUp : PickUp
	{
		// Token: 0x06002A3C RID: 10812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x2DC6C80", Offset = "0x2DC5C80", VA = "0x182DC6C80", Slot = "12")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x2DC6A70", Offset = "0x2DC5A70", VA = "0x182DC6A70", Slot = "25")]
		protected override void Collect()
		{
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x2DC6B30", Offset = "0x2DC5B30", VA = "0x182DC6B30", Slot = "27")]
		protected override bool MainEffect()
		{
			return default(bool);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x2DC6D50", Offset = "0x2DC5D50", VA = "0x182DC6D50")]
		private bool TryWearClothing()
		{
			return default(bool);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x2DC6EE0", Offset = "0x2DC5EE0", VA = "0x182DC6EE0")]
		private IEnumerator WearClothingRoutine()
		{
			return null;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x2DC6E40", Offset = "0x2DC5E40", VA = "0x182DC6E40")]
		private IEnumerator WaitForAnimationStart()
		{
			return null;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x2DC6DF0", Offset = "0x2DC5DF0", VA = "0x182DC6DF0")]
		private IEnumerator WaitForAnimationEnd()
		{
			return null;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x2DC6E90", Offset = "0x2DC5E90", VA = "0x182DC6E90")]
		private IEnumerator WaitForIdle()
		{
			return null;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x2DC6CE0", Offset = "0x2DC5CE0", VA = "0x182DC6CE0")]
		public void OnInterrupted()
		{
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x2DC6800", Offset = "0x2DC5800", VA = "0x182DC6800")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x2DC6AC0", Offset = "0x2DC5AC0", VA = "0x182DC6AC0")]
		private static IEnumerator FadeOutLayer(float blendTime, int targetLayer)
		{
			return null;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x2DC6D30", Offset = "0x2DC5D30", VA = "0x182DC6D30", Slot = "19")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x2DC6290", Offset = "0x2DC5290", VA = "0x182DC6290")]
		public ClothingPickUp()
		{
		}

		// Token: 0x040025C9 RID: 9673
		[Token(Token = "0x40025C9")]
		[FieldOffset(Offset = "0xF8")]
		[EventRef]
		[SerializeField]
		private string _putOnAudioEvent;

		// Token: 0x040025CA RID: 9674
		[Token(Token = "0x40025CA")]
		[FieldOffset(Offset = "0x100")]
		private PlayerClothingSystem _playerClothingSystem;

		// Token: 0x040025CB RID: 9675
		[Token(Token = "0x40025CB")]
		[FieldOffset(Offset = "0x108")]
		private bool _secondaryHoldInputMethodIsActive;
	}
}
