using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class RigidBodySetKinematic : MonoBehaviour
	{
		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA9BF00", Offset = "0xA9A500", VA = "0x180A9BF00")]
		private void OnEnable()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA9C080", Offset = "0xA9A680", VA = "0x180A9C080")]
		private void Update()
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xA9C190", Offset = "0xA9A790", VA = "0x180A9C190")]
		private void Apply(bool value)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xA9C3E0", Offset = "0xA9A9E0", VA = "0x180A9C3E0")]
		public RigidBodySetKinematic()
		{
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _kinematicValue;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _parentToScene;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _delay;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _staggerTime;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Rigidbody> _targets;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x38")]
		private float _enableTime;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x3C")]
		private float _lastAppliedTime;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x40")]
		private int _appliedIndex;
	}
}
