using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public class LightningWhipSpell : LightningSpellScript
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA50DD0", Offset = "0xA4F3D0", VA = "0x180A50DD0")]
		private IEnumerator WhipForward()
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA50E60", Offset = "0xA4F460", VA = "0x180A50E60", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA50F30", Offset = "0xA4F530", VA = "0x180A50F30", Slot = "5")]
		protected override void Update()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA512C0", Offset = "0xA4F8C0", VA = "0x180A512C0", Slot = "8")]
		protected override void OnCastSpell()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected override void OnStopSpell()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA51360", Offset = "0xA4F960", VA = "0x180A51360", Slot = "10")]
		protected override void OnActivated()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA513C0", Offset = "0xA4F9C0", VA = "0x180A513C0", Slot = "11")]
		protected override void OnDeactivated()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA51420", Offset = "0xA4FA20", VA = "0x180A51420")]
		public LightningWhipSpell()
		{
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0xA8")]
		[Header("Whip")]
		[Tooltip("Attach the whip to what object")]
		public GameObject AttachTo;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Rotate the whip with this object")]
		public GameObject RotateWith;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Whip handle")]
		public GameObject WhipHandle;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xC0")]
		[Tooltip("Whip start")]
		public GameObject WhipStart;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("Whip spring")]
		public GameObject WhipSpring;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Whip crack audio source")]
		public AudioSource WhipCrackAudioSource;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public Action<Vector3> CollisionCallback;
	}
}
