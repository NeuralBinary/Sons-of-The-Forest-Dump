using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Physics
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	public class ColliderSetEnabled : MonoBehaviour
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xA975F0", Offset = "0xA95BF0", VA = "0x180A975F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xA97650", Offset = "0xA95C50", VA = "0x180A97650")]
		private void Update()
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xA97890", Offset = "0xA95E90", VA = "0x180A97890")]
		public ColliderSetEnabled()
		{
		}

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Collider> _targets;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _enabledValue;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x2C")]
		private float _enableTime;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _delay;
	}
}
