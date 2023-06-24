using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class PlanarReflection : MonoBehaviour
	{
		// Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2729920", Offset = "0x2727F20", VA = "0x182729920")]
		public void Start()
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2729B30", Offset = "0x2728130", VA = "0x182729B30")]
		public void LateUpdate()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2729BC0", Offset = "0x27281C0", VA = "0x182729BC0")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x272A490", Offset = "0x2728A90", VA = "0x18272A490")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x272A620", Offset = "0x2728C20", VA = "0x18272A620")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x272A7B0", Offset = "0x2728DB0", VA = "0x18272A7B0")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x272AA90", Offset = "0x2729090", VA = "0x18272AA90")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x272AC70", Offset = "0x2729270", VA = "0x18272AC70")]
		public void OnEnable()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x272AD40", Offset = "0x2729340", VA = "0x18272AD40")]
		public void OnDisable()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x272AE10", Offset = "0x2729410", VA = "0x18272AE10")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x272C100", Offset = "0x272A700", VA = "0x18272C100")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x272C250", Offset = "0x272A850", VA = "0x18272C250")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x272C460", Offset = "0x272AA60", VA = "0x18272C460")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x272C5E0", Offset = "0x272ABE0", VA = "0x18272C5E0")]
		private static float Sgn(float a)
		{
			return 0f;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x272C610", Offset = "0x272AC10", VA = "0x18272C610")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x272CA30", Offset = "0x272B030", VA = "0x18272CA30")]
		public PlanarReflection()
		{
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask reflectionMask;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x24")]
		public bool reflectSkybox;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x28")]
		public Color clearColor;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x38")]
		public string reflectionSampler;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x40")]
		public float clipPlaneOffset;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_Oldpos;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x50")]
		private Camera m_ReflectionCamera;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x58")]
		private Material m_SharedMaterial;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<Camera, bool> m_HelperCameras;
	}
}
