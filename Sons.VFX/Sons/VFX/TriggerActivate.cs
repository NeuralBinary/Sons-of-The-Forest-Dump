using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Sons.VFX
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[AddComponentMenu("Sons/VFX/TriggerActivate")]
	public class TriggerActivate : MonoBehaviour
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3176220", Offset = "0x3174820", VA = "0x183176220")]
		private bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x31762A0", Offset = "0x31748A0", VA = "0x1831762A0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x31767C0", Offset = "0x3174DC0", VA = "0x1831767C0")]
		private void Start()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3176B30", Offset = "0x3175130", VA = "0x183176B30")]
		private void Update()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3176B90", Offset = "0x3175190", VA = "0x183176B90")]
		private void OnDisable()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x3176BA0", Offset = "0x31751A0", VA = "0x183176BA0")]
		private void DoDisable()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x3176DF0", Offset = "0x31753F0", VA = "0x183176DF0")]
		public void Play()
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x3177290", Offset = "0x3175890", VA = "0x183177290")]
		private void Reset()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x31776B0", Offset = "0x3175CB0", VA = "0x1831776B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x3177850", Offset = "0x3175E50", VA = "0x183177850")]
		public TriggerActivate()
		{
		}

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targets;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public UnityEvent _activateEvents;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayerMask _triggerLayerMask;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _triggerTagMask;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _disableTime;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _hideOnDisable;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		private bool _autoReset;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_minTimeBetweenTime")]
		[SerializeField]
		private float _resetTime;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x4C")]
		private bool _running;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x50")]
		private RealtimeAutoTimer _disableTimer;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x58")]
		private RealtimeAutoTimer _resetTimer;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<GameObject, Vector3[]> _storedInitialTransforms;
	}
}
