using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[RequireComponent(typeof(ParticleSystem))]
	public class WaterParticleSystem : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x17000001")]
		public int TriDataLength
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2700660", Offset = "0x26FEC60", VA = "0x182700660")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x17000002")]
		public int TriDataStart
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x27006C0", Offset = "0x26FECC0", VA = "0x1827006C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x17000003")]
		public int TriDataEnd
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x27006E0", Offset = "0x26FECE0", VA = "0x1827006E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x17000004")]
		public int VertDataLength
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2700700", Offset = "0x26FED00", VA = "0x182700700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x17000005")]
		public int VertDataStart
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2700760", Offset = "0x26FED60", VA = "0x182700760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x17000006")]
		public int VertDataEnd
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2700780", Offset = "0x26FED80", VA = "0x182700780")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x27007A0", Offset = "0x26FEDA0", VA = "0x1827007A0")]
		private void Start()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2700DA0", Offset = "0x26FF3A0", VA = "0x182700DA0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2700F10", Offset = "0x26FF510", VA = "0x182700F10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2700FD0", Offset = "0x26FF5D0", VA = "0x182700FD0")]
		private void EmitNew()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x27016F0", Offset = "0x26FFCF0", VA = "0x1827016F0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2701970", Offset = "0x26FFF70", VA = "0x182701970")]
		private void EmitParticle(Vector3 p0, Vector3 p1, float elevation, Vector3 velocity, Vector3 normal, Vector3 force, float area)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2701D10", Offset = "0x2700310", VA = "0x182701D10")]
		public WaterParticleSystem()
		{
		}

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Should the particle system emit?")]
		public bool emit;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Render queue of the water particle material.")]
		public int renderQueue;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Elevation above water at which the particles will spawn. Used to avoid clipping.")]
		[Range(0f, 0.1f)]
		public float surfaceElevation;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Initial size of the particle.")]
		[Range(0f, 64f)]
		public float startSize;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Velocity object has to have to emit particles.")]
		[Range(0.1f, 5f)]
		[FormerlySerializedAs("sleepTresholdVelocity")]
		public float sleepThresholdVelocity;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Determines how much velocity of the object will affect initial particle speed.")]
		[Range(0f, 5f)]
		public float initialVelocityModifier;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Limit initial alpha to this value.")]
		public float maxInitialAlpha;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		[Tooltip("Multiplies initial alpha by this value. Alpha cannot be higher than maxInitialAlpha.")]
		public float initialAlphaModifier;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("How many particles should be emitted each 'emitTimeInterval' seconds.")]
		[Range(0f, 20f)]
		public int emitPerCycle;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Determines how often the particles will be emitted.")]
		[Range(0f, 0.1f)]
		public float emitTimeInterval;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("Script will try to predict where the object will be in the next n frames.")]
		public int positionExtrapolationFrames;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x4C")]
		private float _timeElapsed;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x50")]
		private WaterObject _targetWaterObject;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem _particleSystem;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x60")]
		private int[] _waterlineIndices;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x68")]
		private float _volumeOfMesh;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x70")]
		private ParticleSystem.NoiseModule _noiseModule;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x78")]
		private bool _initialized;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x7C")]
		private int _prevDataLength;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x80")]
		private int _waterlineCount;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x88")]
		private WaterObjectManager _wom;
	}
}
