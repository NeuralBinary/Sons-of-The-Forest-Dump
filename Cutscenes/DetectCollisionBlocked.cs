using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cutscenes
{
	// Token: 0x0200076E RID: 1902
	[Token(Token = "0x200076E")]
	public class DetectCollisionBlocked : MonoBehaviour
	{
		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x1700064A")]
		public bool IsBlocked
		{
			[Token(Token = "0x60031F5")]
			[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x2E44F80", Offset = "0x2E43F80", VA = "0x182E44F80")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x2E44C70", Offset = "0x2E43C70", VA = "0x182E44C70")]
		private void LateUpdate()
		{
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x2E450B0", Offset = "0x2E440B0", VA = "0x182E450B0")]
		public DetectCollisionBlocked()
		{
		}

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tagFilter;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x28")]
		private List<Collider> _activeBlockers;

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		[FieldOffset(Offset = "0x30")]
		private List<Collider> _inactiveBlockers;

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Collider, int> _activeBlockersFrames;

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x40")]
		private bool _blocked;
	}
}
