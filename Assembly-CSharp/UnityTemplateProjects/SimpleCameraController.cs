using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityTemplateProjects
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class SimpleCameraController : MonoBehaviour
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5E3510", Offset = "0x5E1B10", VA = "0x1805E3510")]
		private void OnEnable()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5E35E0", Offset = "0x5E1BE0", VA = "0x1805E35E0")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5E3AB0", Offset = "0x5E20B0", VA = "0x1805E3AB0")]
		private void Update()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5E4310", Offset = "0x5E2910", VA = "0x1805E4310")]
		public SimpleCameraController()
		{
		}

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		private SimpleCameraController.CameraState m_TargetCameraState;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		private SimpleCameraController.CameraState m_InterpolatingCameraState;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x34")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		public float positionLerpTime;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x38")]
		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		private class CameraState
		{
			// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x5E45B0", Offset = "0x5E2BB0", VA = "0x1805E45B0")]
			public void SetFromTransform(Transform t)
			{
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x5E4870", Offset = "0x5E2E70", VA = "0x1805E4870")]
			public void Translate(Vector3 translation)
			{
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x5E4990", Offset = "0x5E2F90", VA = "0x1805E4990")]
			public void LerpTowards(SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x5E4AE0", Offset = "0x5E30E0", VA = "0x1805E4AE0")]
			public void UpdateTransform(Transform t)
			{
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CameraState()
			{
			}

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x10")]
			public float yaw;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x14")]
			public float pitch;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x18")]
			public float roll;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x1C")]
			public float x;

			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x20")]
			public float y;

			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x24")]
			public float z;
		}
	}
}
