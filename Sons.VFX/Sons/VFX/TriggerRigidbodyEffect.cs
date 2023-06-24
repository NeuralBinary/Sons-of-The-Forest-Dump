using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.VFX
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[AddComponentMenu("Sons/VFX/TriggerRigidbodyEffect")]
	public class TriggerRigidbodyEffect : MonoBehaviour
	{
		// Token: 0x060000EA RID: 234 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x31779E0", Offset = "0x3175FE0", VA = "0x1831779E0")]
		private bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x3177A60", Offset = "0x3176060", VA = "0x183177A60")]
		private void Start()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x3177DD0", Offset = "0x31763D0", VA = "0x183177DD0")]
		private void Update()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x3177E30", Offset = "0x3176430", VA = "0x183177E30")]
		private void OnDisable()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x3177E40", Offset = "0x3176440", VA = "0x183177E40")]
		private void DoDisable()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x31780D0", Offset = "0x31766D0", VA = "0x1831780D0")]
		public void Play()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x31784B0", Offset = "0x3176AB0", VA = "0x1831784B0")]
		private void Reset()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x3178910", Offset = "0x3176F10", VA = "0x183178910")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x3178AB0", Offset = "0x31770B0", VA = "0x183178AB0")]
		public TriggerRigidbodyEffect()
		{
		}

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Rigidbody> _targets;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _triggerLayerMask;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _triggerTagMask;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _disableTime;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _hideOnDisable;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _autoReset;

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_minTimeBetweenTime")]
		private float _resetTime;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x44")]
		private bool _running;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x48")]
		private RealtimeAutoTimer _disableTimer;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x50")]
		private RealtimeAutoTimer _resetTimer;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Rigidbody, Vector3[]> _storedInitialTransforms;
	}
}
