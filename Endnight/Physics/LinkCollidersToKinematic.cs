using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class LinkCollidersToKinematic : MonoBehaviour
	{
		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA9A1B0", Offset = "0xA987B0", VA = "0x180A9A1B0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA9A600", Offset = "0xA98C00", VA = "0x180A9A600")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA9A7A0", Offset = "0xA98DA0", VA = "0x180A9A7A0")]
		private void Apply(bool rigidbodyIsKinematic)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA9A7F0", Offset = "0xA98DF0", VA = "0x180A9A7F0")]
		private void ProcessColliders(List<Collider> colliders, bool setEnabled)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LinkCollidersToKinematic()
		{
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _disabledWhenKinematicColliderHolder;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> _disabledWhenKinematicColliders;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _enabledWhenKinematicColliderHolder;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Collider> _enabledWhenKinematicColliders;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _autoCollectInChildren;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x49")]
		private bool _hasInitialized;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x4A")]
		private bool _appliedKinematic;
	}
}
