using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2000925")]
	[AddComponentMenu("Sons/Ragdoll/RagdollAudio")]
	public class RagdollAudio : MonoBehaviour
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433D")]
		[Address(RVA = "0x3642950", Offset = "0x3640F50", VA = "0x183642950")]
		private void OnValidate()
		{
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433E")]
		[Address(RVA = "0x3642A80", Offset = "0x3641080", VA = "0x183642A80")]
		private void PlayAudio(string evt, VailAudioManager.Noise vailNoise, out float nextEventTime)
		{
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600433F")]
		[Address(RVA = "0x3642CD0", Offset = "0x36412D0", VA = "0x183642CD0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004340")]
		[Address(RVA = "0x3643170", Offset = "0x3641770", VA = "0x183643170")]
		public void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x3643470", Offset = "0x3641A70", VA = "0x183643470")]
		public RagdollAudio()
		{
		}

		// Token: 0x04004679 RID: 18041
		[Token(Token = "0x4004679")]
		[FieldOffset(Offset = "0x20")]
		[EventRef]
		[SerializeField]
		private string _impactEvent;

		// Token: 0x0400467A RID: 18042
		[Token(Token = "0x400467A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EventRef]
		private string _bumpEvent;

		// Token: 0x0400467B RID: 18043
		[Token(Token = "0x400467B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _checkWaterImpact;

		// Token: 0x0400467C RID: 18044
		[Token(Token = "0x400467C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[EventRef]
		private string _impactEventWater;

		// Token: 0x0400467D RID: 18045
		[Token(Token = "0x400467D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _cooldown;

		// Token: 0x0400467E RID: 18046
		[Token(Token = "0x400467E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _impactSpeed;

		// Token: 0x0400467F RID: 18047
		[Token(Token = "0x400467F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _bumpSpeed;

		// Token: 0x04004680 RID: 18048
		[Token(Token = "0x4004680")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04004681 RID: 18049
		[Token(Token = "0x4004681")]
		[FieldOffset(Offset = "0x58")]
		private float _nextImpactTime;

		// Token: 0x04004682 RID: 18050
		[Token(Token = "0x4004682")]
		[FieldOffset(Offset = "0x5C")]
		private float _nextBumpTime;

		// Token: 0x04004683 RID: 18051
		[Token(Token = "0x4004683")]
		[FieldOffset(Offset = "0x60")]
		private float _nextWaterImpactTime;
	}
}
