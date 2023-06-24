using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x02000450 RID: 1104
	[Token(Token = "0x2000450")]
	public class PlayerRainFollow : MonoBehaviour
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C97")]
		[Address(RVA = "0x32C5550", Offset = "0x32C3B50", VA = "0x1832C5550")]
		private void Awake()
		{
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x32C5590", Offset = "0x32C3B90", VA = "0x1832C5590")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x32C5F00", Offset = "0x32C4500", VA = "0x1832C5F00")]
		public PlayerRainFollow()
		{
		}

		// Token: 0x04001B2B RID: 6955
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x20")]
		public float _velocityOffsetRatio;

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x24")]
		public float _angularVelocityOffsetRatio;

		// Token: 0x04001B2D RID: 6957
		[Token(Token = "0x4001B2D")]
		[FieldOffset(Offset = "0x28")]
		private Transform _target;

		// Token: 0x04001B2E RID: 6958
		[Token(Token = "0x4001B2E")]
		[FieldOffset(Offset = "0x30")]
		private float _newYRot;

		// Token: 0x04001B2F RID: 6959
		[Token(Token = "0x4001B2F")]
		[FieldOffset(Offset = "0x34")]
		private float _lastYRot;

		// Token: 0x04001B30 RID: 6960
		[Token(Token = "0x4001B30")]
		[FieldOffset(Offset = "0x38")]
		private float _angularVelocity;

		// Token: 0x04001B31 RID: 6961
		[Token(Token = "0x4001B31")]
		[FieldOffset(Offset = "0x3C")]
		private float _velocityOffset;

		// Token: 0x04001B32 RID: 6962
		[Token(Token = "0x4001B32")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _angularVelocityDir;
	}
}
