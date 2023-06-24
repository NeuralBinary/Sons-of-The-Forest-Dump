using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Utilities
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class ConstrainWorldTransform : MonoBehaviour
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA6CA40", Offset = "0xA6B040", VA = "0x180A6CA40")]
		private void OnValidate()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA6CBD0", Offset = "0xA6B1D0", VA = "0x180A6CBD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA6CCC0", Offset = "0xA6B2C0", VA = "0x180A6CCC0")]
		private void Apply()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA6CDA0", Offset = "0xA6B3A0", VA = "0x180A6CDA0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xA6CE60", Offset = "0xA6B460", VA = "0x180A6CE60")]
		private void OnDisable()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA6CF40", Offset = "0xA6B540", VA = "0x180A6CF40")]
		private void Setup()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA6CFF0", Offset = "0xA6B5F0", VA = "0x180A6CFF0")]
		private void SetupRotationTarget()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ConstrainWorldTransform()
		{
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x20")]
		private bool _active;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _defaultPos;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Quaternion _defaultRot;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _fixedTargetPos;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[FormerlySerializedAs("_fixedTargetRot")]
		private bool _fixedTargetRotX;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x42")]
		[SerializeField]
		private bool _fixedTargetRotY;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x43")]
		[SerializeField]
		private bool _fixedTargetRotZ;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _onEnable;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _targetPos;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Quaternion _targetRot;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[HideInInspector]
		private Transform _cachedTransform;
	}
}
