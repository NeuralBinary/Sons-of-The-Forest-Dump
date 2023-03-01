using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public class PoolingActivation : MonoBehaviour
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205D")]
		[Address(RVA = "0x2D2DE30", Offset = "0x2D2CE30", VA = "0x182D2DE30")]
		private void InitializeArrays()
		{
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205E")]
		[Address(RVA = "0x2D2D930", Offset = "0x2D2C930", VA = "0x182D2D930")]
		public void AutoFindBehaviours()
		{
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205F")]
		[Address(RVA = "0x2D2E1A0", Offset = "0x2D2D1A0", VA = "0x182D2E1A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002060")]
		[Address(RVA = "0x2D2DE10", Offset = "0x2D2CE10", VA = "0x182D2DE10")]
		public void DoActivation()
		{
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002061")]
		[Address(RVA = "0x2D2DE20", Offset = "0x2D2CE20", VA = "0x182D2DE20")]
		public void DoDeactivation()
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002062")]
		[Address(RVA = "0x2D2E1B0", Offset = "0x2D2D1B0", VA = "0x182D2E1B0")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x2D2E1C0", Offset = "0x2D2D1C0", VA = "0x182D2E1C0")]
		private void SetBehaviourActive(bool behaviourEnabled)
		{
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002064")]
		[Address(RVA = "0x556D40", Offset = "0x555D40", VA = "0x180556D40")]
		public PoolingActivation()
		{
		}

		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Behaviour> _behaviours;

		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x04001E26 RID: 7718
		[Token(Token = "0x4001E26")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Rigidbody> _rigidbodies;

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Renderer> _renderers;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<LODGroup> _lodGroups;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ParticleSystem> _particleSystems;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoFindBehaviours;
	}
}
