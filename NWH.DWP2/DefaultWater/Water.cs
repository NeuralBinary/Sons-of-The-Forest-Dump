using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x272D1D0", Offset = "0x272B7D0", VA = "0x18272D1D0")]
		private void Update()
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x272D640", Offset = "0x272BC40", VA = "0x18272D640")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x272E4A0", Offset = "0x272CAA0", VA = "0x18272E4A0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x272EBE0", Offset = "0x272D1E0", VA = "0x18272EBE0")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x272F1B0", Offset = "0x272D7B0", VA = "0x18272F1B0")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x27304D0", Offset = "0x272EAD0", VA = "0x1827304D0")]
		private Water.WaterMode GetWaterMode()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x27304E0", Offset = "0x272EAE0", VA = "0x1827304E0")]
		private Water.WaterMode FindHardwareWaterSupport()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2730780", Offset = "0x272ED80", VA = "0x182730780")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2730BA0", Offset = "0x272F1A0", VA = "0x182730BA0")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2730CC0", Offset = "0x272F2C0", VA = "0x182730CC0")]
		public Water()
		{
		}

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		public Water.WaterMode waterMode;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x24")]
		public bool disablePixelLights;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		public int textureSize;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x2C")]
		public float clipPlaneOffset;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x30")]
		public LayerMask reflectLayers;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x34")]
		public LayerMask refractLayers;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<Camera, Camera> m_ReflectionCameras;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<Camera, Camera> m_RefractionCameras;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_ReflectionTexture;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture m_RefractionTexture;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x58")]
		private Water.WaterMode m_HardwareWaterSupport;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x5C")]
		private int m_OldReflectionTextureSize;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x60")]
		private int m_OldRefractionTextureSize;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		public enum WaterMode
		{
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			Simple,
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			Reflective,
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			Refractive
		}
	}
}
