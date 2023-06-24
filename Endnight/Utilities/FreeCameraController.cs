using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class FreeCameraController : MonoBehaviour
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA73BA0", Offset = "0xA721A0", VA = "0x180A73BA0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x5E3510", Offset = "0x5E1B10", VA = "0x1805E3510")]
		public void ResetTransforms()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x5E35E0", Offset = "0x5E1BE0", VA = "0x1805E35E0")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA73BB0", Offset = "0xA721B0", VA = "0x180A73BB0")]
		private void Update()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA74410", Offset = "0xA72A10", VA = "0x180A74410")]
		public FreeCameraController()
		{
		}

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x20")]
		private FreeCameraController.CameraState m_TargetCameraState;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		private FreeCameraController.CameraState m_InterpolatingCameraState;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		[Header("Movement Settings")]
		public float boost;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x34")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		public float positionLerpTime;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		[Header("Rotation Settings")]
		public AnimationCurve mouseSensitivityCurve;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		private class CameraState
		{
			// Token: 0x06000122 RID: 290 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x5E45B0", Offset = "0x5E2BB0", VA = "0x1805E45B0")]
			public void SetFromTransform(Transform t)
			{
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x5E4870", Offset = "0x5E2E70", VA = "0x1805E4870")]
			public void Translate(Vector3 translation)
			{
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x5E4990", Offset = "0x5E2F90", VA = "0x1805E4990")]
			public void LerpTowards(FreeCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x5E4AE0", Offset = "0x5E30E0", VA = "0x1805E4AE0")]
			public void UpdateTransform(Transform t)
			{
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CameraState()
			{
			}

			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			[FieldOffset(Offset = "0x10")]
			public float yaw;

			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x14")]
			public float pitch;

			// Token: 0x040000C8 RID: 200
			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x18")]
			public float roll;

			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x1C")]
			public float x;

			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			[FieldOffset(Offset = "0x20")]
			public float y;

			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x24")]
			public float z;
		}
	}
}
