using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[RequireComponent(typeof(AudioSource))]
	public class LightningWhipScript : MonoBehaviour
	{
		// Token: 0x0600015F RID: 351 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA49AC0", Offset = "0xA480C0", VA = "0x180A49AC0")]
		private IEnumerator WhipForward()
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA49B50", Offset = "0xA48150", VA = "0x180A49B50")]
		private void Start()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xA49EB0", Offset = "0xA484B0", VA = "0x180A49EB0")]
		private void Update()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xA4A530", Offset = "0xA48B30", VA = "0x180A4A530")]
		public LightningWhipScript()
		{
		}

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip WhipCrack;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip WhipCrackThunder;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		private AudioSource audioSource;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		private GameObject whipStart;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x40")]
		private GameObject whipEndStrike;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x48")]
		private GameObject whipHandle;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x50")]
		private GameObject whipSpring;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 prevDrag;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x60")]
		private bool dragging;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x61")]
		private bool canWhip;
	}
}
