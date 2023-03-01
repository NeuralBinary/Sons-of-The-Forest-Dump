using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	[AddComponentMenu("Sons/Ragdoll/RagdollAudio")]
	public class RagdollAudio : MonoBehaviour
	{
		// Token: 0x06003C0C RID: 15372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x2F24FB0", Offset = "0x2F23FB0", VA = "0x182F24FB0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x2F25050", Offset = "0x2F24050", VA = "0x182F25050")]
		private void PlayAudio(string evt, VailAudioManager.Noise vailNoise, out float nextEventTime)
		{
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x2F24C20", Offset = "0x2F23C20", VA = "0x182F24C20")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x2F24E60", Offset = "0x2F23E60", VA = "0x182F24E60")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x2F25140", Offset = "0x2F24140", VA = "0x182F25140")]
		public RagdollAudio()
		{
		}

		// Token: 0x0400404A RID: 16458
		[Token(Token = "0x400404A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[EventRef]
		private string _impactEvent;

		// Token: 0x0400404B RID: 16459
		[Token(Token = "0x400404B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EventRef]
		private string _bumpEvent;

		// Token: 0x0400404C RID: 16460
		[Token(Token = "0x400404C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _checkWaterImpact;

		// Token: 0x0400404D RID: 16461
		[Token(Token = "0x400404D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _impactEventWater;

		// Token: 0x0400404E RID: 16462
		[Token(Token = "0x400404E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x0400404F RID: 16463
		[Token(Token = "0x400404F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _impactSpeed;

		// Token: 0x04004050 RID: 16464
		[Token(Token = "0x4004050")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _bumpSpeed;

		// Token: 0x04004051 RID: 16465
		[Token(Token = "0x4004051")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04004052 RID: 16466
		[Token(Token = "0x4004052")]
		[FieldOffset(Offset = "0x58")]
		private float _nextImpactTime;

		// Token: 0x04004053 RID: 16467
		[Token(Token = "0x4004053")]
		[FieldOffset(Offset = "0x5C")]
		private float _nextBumpTime;

		// Token: 0x04004054 RID: 16468
		[Token(Token = "0x4004054")]
		[FieldOffset(Offset = "0x60")]
		private float _nextWaterImpactTime;
	}
}
