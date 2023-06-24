using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public class UnityEventExtensions : MonoBehaviour
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xA8C610", Offset = "0xA8AC10", VA = "0x180A8C610")]
		public void DestroyTargets()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0xA8C800", Offset = "0xA8AE00", VA = "0x180A8C800")]
		public void DestroyTargetsDelayed(float delay)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xA8C860", Offset = "0xA8AE60", VA = "0x180A8C860")]
		public void ClearParentTargets()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UnityEventExtensions()
		{
		}

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> _targets;
	}
}
