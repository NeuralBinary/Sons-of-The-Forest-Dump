using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	public class PlayerFollow : MonoBehaviour
	{
		// Token: 0x06001C92 RID: 7314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x32C4980", Offset = "0x32C2F80", VA = "0x1832C4980")]
		private void Awake()
		{
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x32C49C0", Offset = "0x32C2FC0", VA = "0x1832C49C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x32C49D0", Offset = "0x32C2FD0", VA = "0x1832C49D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x32C49E0", Offset = "0x32C2FE0", VA = "0x1832C49E0")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerFollow()
		{
		}

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 _forwardOffset;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x2C")]
		public bool _matchRotation;

		// Token: 0x04001B28 RID: 6952
		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x2D")]
		public bool _useVrCamera;

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x2E")]
		public bool _useVrWatch;

		// Token: 0x04001B2A RID: 6954
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x2F")]
		public bool _onEnable;
	}
}
