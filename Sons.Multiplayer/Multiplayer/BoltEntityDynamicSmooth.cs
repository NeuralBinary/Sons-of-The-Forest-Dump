using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Multiplayer
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class BoltEntityDynamicSmooth : EntityBehaviour
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x30D4420", Offset = "0x30D2A20", VA = "0x1830D4420")]
		private void OnValidate()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x30D4450", Offset = "0x30D2A50", VA = "0x1830D4450")]
		private void Start()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x30D4720", Offset = "0x30D2D20", VA = "0x1830D4720")]
		private void OnEnable()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x30D4730", Offset = "0x30D2D30", VA = "0x1830D4730")]
		private void ResetSmoothedTransformValues()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x30D49A0", Offset = "0x30D2FA0", VA = "0x1830D49A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x30D4DC0", Offset = "0x30D33C0", VA = "0x1830D4DC0")]
		private bool ShouldUpdate()
		{
			return default(bool);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x30D4F80", Offset = "0x30D3580", VA = "0x1830D4F80")]
		private void DoRotationSmooth(Quaternion thisRotation, ref Quaternion currentSmoothRotation, float smoothSpeed)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x30D5070", Offset = "0x30D3670", VA = "0x1830D5070")]
		private bool DoPositionSmooth(Vector3 thisPosition, ref Vector3 currentSmoothPosition, float smoothSpeed)
		{
			return default(bool);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x30D5210", Offset = "0x30D3810", VA = "0x1830D5210")]
		private void SmoothLocalRotation()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x30D5320", Offset = "0x30D3920", VA = "0x1830D5320")]
		private void SmoothRotation()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x30D5430", Offset = "0x30D3A30", VA = "0x1830D5430")]
		private void SmoothPosition()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x30D5560", Offset = "0x30D3B60", VA = "0x1830D5560")]
		private void SmoothLocalPosition()
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x30D4720", Offset = "0x30D2D20", VA = "0x1830D4720", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x30D5690", Offset = "0x30D3C90", VA = "0x1830D5690")]
		public BoltEntityDynamicSmooth()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _smoothLocalPosition;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _smoothPosition;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _smoothLocalRotation;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x2B")]
		[FormerlySerializedAs("smoothRotation")]
		[SerializeField]
		private bool _smoothRotation;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("updateOnClientOnly")]
		[SerializeField]
		private bool _updateOnClientOnly;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_smoothSpeed")]
		[SerializeField]
		private float _smoothPositionSpeed;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _smoothRotationSpeed;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("_smoothMaxRange")]
		private float _smoothPositionMaxRange;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x3C")]
		private float _maxRangeSqr;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _currentSmoothLocalPosition;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion _currentSmoothLocalRotation;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _currentSmoothPosition;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x68")]
		private Quaternion _currentSmoothRotation;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x78")]
		private Transform _thisTransform;
	}
}
