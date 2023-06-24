using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Rendering
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[RequireComponent(typeof(Camera))]
	public class FireVolume : MonoBehaviour
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x5EAD00", Offset = "0x5E9300", VA = "0x1805EAD00")]
		private void OnEnable()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x5EB660", Offset = "0x5E9C60", VA = "0x1805EB660")]
		private void OnDisable()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x5EB8B0", Offset = "0x5E9EB0", VA = "0x1805EB8B0")]
		private void UpdateFireVolumeParams()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x5EBB00", Offset = "0x5EA100", VA = "0x1805EBB00")]
		private void FireVolumeRender(ScriptableRenderContext context, Camera camera)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x5EC4E0", Offset = "0x5EAAE0", VA = "0x1805EC4E0")]
		public FireVolume()
		{
		}

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Size of the volume (m) in world space.")]
		private Vector3 _fireVolumeSize;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Resolution of the 3D texture.")]
		private Vector3 _fireVolumeResolution;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x38")]
		private float _stepSize;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x40")]
		private Transform _transform;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x48")]
		private float _distanceSqr;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		private const int _maxParticles = 256;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x50")]
		private Vector4[] _activeParticles;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x58")]
		private int _lastActiveParticles;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x60")]
		private RenderTexture _fireParticlesVolume;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x68")]
		private RenderTexture _finalFireParticlesVolume;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x70")]
		private ComputeShader _computeBufferShader;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x78")]
		private int _computeClearKernel;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x7C")]
		private int _computeBufferKernel;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x80")]
		private int _computeCopyKernel;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x84")]
		private int _dispatchX;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x88")]
		private int _dispatchY;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x8C")]
		private int _dispatchZ;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _activeFireParticlesId;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _activeFireParticlesCountId;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _fireVolumeLowerLeftCornerComputeId;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _fireVolumeLowerLeftCornerId;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _fireVolumeSizeId;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int _oneOverFireVolumeSizeId;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int _fireVolumeResolutionId;
	}
}
