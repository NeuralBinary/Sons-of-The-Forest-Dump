using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Atmosphere
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public class DirectionalLightRotation : TimeOfDayBehaviour
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2D3FBE0", Offset = "0x2D3E1E0", VA = "0x182D3FBE0", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2D3FFB0", Offset = "0x2D3E5B0", VA = "0x182D3FFB0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2403EB0", Offset = "0x24024B0", VA = "0x182403EB0")]
		public float GetTimeRotationOffset()
		{
			return 0f;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2D40560", Offset = "0x2D3EB60", VA = "0x182D40560")]
		public Quaternion GetBaseRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2D40570", Offset = "0x2D3EB70", VA = "0x182D40570")]
		public DirectionalLightRotation()
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _target;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _curve;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_startOffset")]
		private Vector3 _prevStartOffset;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[HideInInspector]
		private bool _appliedPrev;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Quaternion _startRotationOffset;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Quaternion _rotation;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _hideGizmo;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _gizmoColor;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x90")]
		private float _timeRotationOffset;
	}
}
