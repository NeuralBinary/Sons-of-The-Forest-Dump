using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Physics
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class WorldTransformOffset : MonoBehaviour
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x3110420", Offset = "0x310EA20", VA = "0x183110420")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x3110430", Offset = "0x310EA30", VA = "0x183110430")]
		private void DoApply()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x31107A0", Offset = "0x310EDA0", VA = "0x1831107A0")]
		private void DoApplyDirection()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x31108E0", Offset = "0x310EEE0", VA = "0x1831108E0")]
		private Quaternion CalculateRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x3110C20", Offset = "0x310F220", VA = "0x183110C20")]
		private Vector3 GetWorldUpVector()
		{
			return default(Vector3);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x3110DD0", Offset = "0x310F3D0", VA = "0x183110DD0")]
		private void DoApplyOffset()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x3111110", Offset = "0x310F710", VA = "0x183111110")]
		private Vector3 GetLocalOffset()
		{
			return default(Vector3);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x31112C0", Offset = "0x310F8C0", VA = "0x1831112C0")]
		private void InitializePositions()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x3111450", Offset = "0x310FA50", VA = "0x183111450")]
		public WorldTransformOffset()
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _target;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _amount;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _applyDirection;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 _direction;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _localUpVector;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _keepAlignedToUpVector;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x54")]
		private Vector3? _basePosition;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x64")]
		[FormerlySerializedAs("_rotationOffset")]
		[SerializeField]
		private Vector3 _alignedRotationOffset;
	}
}
