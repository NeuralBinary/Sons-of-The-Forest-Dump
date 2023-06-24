using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	public class DeleteTargets : MonoBehaviour
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA6E4B0", Offset = "0xA6CAB0", VA = "0x180A6E4B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA6E4C0", Offset = "0xA6CAC0", VA = "0x180A6E4C0")]
		private void DoDelete()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DeleteTargets()
		{
		}

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targets;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _delay;
	}
}
