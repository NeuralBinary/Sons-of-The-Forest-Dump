using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class FloatingOrigin : MonoBehaviour
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x9CE200", Offset = "0x9CC800", VA = "0x1809CE200")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x9CE650", Offset = "0x9CCC50", VA = "0x1809CE650")]
		private void MoveOrigin(Vector3 newOrigin)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x9CE6E0", Offset = "0x9CCCE0", VA = "0x1809CE6E0")]
		private void MoveOriginTransforms(Vector3 newOrigin)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x9CE980", Offset = "0x9CCF80", VA = "0x1809CE980")]
		private void MoveOriginParticles(Vector3 newOrigin)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x9CECE0", Offset = "0x9CD2E0", VA = "0x1809CECE0")]
		private void MoveOriginOcean(Vector3 newOrigin)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x9CF2F0", Offset = "0x9CD8F0", VA = "0x1809CF2F0")]
		private void MoveOriginDisablePhysics()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x9CF550", Offset = "0x9CDB50", VA = "0x1809CF550")]
		public FloatingOrigin()
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Use a power of 2 to avoid pops in ocean surface geometry.")]
		[SerializeField]
		private float _threshold;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("Set to zero to disable.")]
		private float _physicsThreshold;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _defaultSleepThreshold;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Optionally provide a list of transforms to avoid doing a FindObjectsOfType() call.")]
		[SerializeField]
		private Transform[] _overrideTransformList;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Optionally provide a list of particle systems to avoid doing a FindObjectsOfType() call.")]
		[SerializeField]
		private ParticleSystem[] _overrideParticleSystemList;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Optionally provide a list of rigidbodies to avoid doing a FindObjectsOfType() call.")]
		[SerializeField]
		private Rigidbody[] _overrideRigidbodyList;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Optionally provide a list of Gerstner components to avoid doing a FindObjectsOfType() call.")]
		[SerializeField]
		private ShapeGerstnerBatched[] _overrideGerstnerList;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x50")]
		private ParticleSystem.Particle[] _particleBuffer;
	}
}
