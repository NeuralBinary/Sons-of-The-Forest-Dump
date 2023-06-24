using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	public class PoolingActivation : MonoBehaviour
	{
		// Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x331EE60", Offset = "0x331D460", VA = "0x18331EE60")]
		private void InitializeArrays()
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x331F380", Offset = "0x331D980", VA = "0x18331F380")]
		public void AutoFindBehaviours()
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x331F950", Offset = "0x331DF50", VA = "0x18331F950")]
		private void OnValidate()
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x331F960", Offset = "0x331DF60", VA = "0x18331F960")]
		public void DoActivation()
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x331F970", Offset = "0x331DF70", VA = "0x18331F970")]
		public void DoDeactivation()
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x331F980", Offset = "0x331DF80", VA = "0x18331F980")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x331F990", Offset = "0x331DF90", VA = "0x18331F990")]
		private void SetBehaviourActive(bool behaviourEnabled)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x5E2580", Offset = "0x5E0B80", VA = "0x1805E2580")]
		public PoolingActivation()
		{
		}

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Behaviour> _behaviours;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Rigidbody> _rigidbodies;

		// Token: 0x04001E97 RID: 7831
		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Renderer> _renderers;

		// Token: 0x04001E98 RID: 7832
		[Token(Token = "0x4001E98")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<LODGroup> _lodGroups;

		// Token: 0x04001E99 RID: 7833
		[Token(Token = "0x4001E99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<ParticleSystem> _particleSystems;

		// Token: 0x04001E9A RID: 7834
		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _autoFindBehaviours;
	}
}
