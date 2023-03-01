using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public class PlayerRainFollow : MonoBehaviour
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x2CEC6F0", Offset = "0x2CEB6F0", VA = "0x182CEC6F0")]
		private void Awake()
		{
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x2CFE850", Offset = "0x2CFD850", VA = "0x182CFE850")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x2CFEFC0", Offset = "0x2CFDFC0", VA = "0x182CFEFC0")]
		public PlayerRainFollow()
		{
		}

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0x20")]
		public float _velocityOffsetRatio;

		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		[FieldOffset(Offset = "0x24")]
		public float _angularVelocityOffsetRatio;

		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		[FieldOffset(Offset = "0x28")]
		private Transform _target;

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x30")]
		private float _newYRot;

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		[FieldOffset(Offset = "0x34")]
		private float _lastYRot;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		[FieldOffset(Offset = "0x38")]
		private float _angularVelocity;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x3C")]
		private float _velocityOffset;

		// Token: 0x04001B0E RID: 6926
		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _angularVelocityDir;
	}
}
