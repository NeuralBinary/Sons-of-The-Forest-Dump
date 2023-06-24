using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[AddComponentMenu("Sons/Environment/WindGustedParticles")]
	public class WindGustedParticles : MonoBehaviour, IWindReceiver
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2F9D590", Offset = "0x2F9BB90", VA = "0x182F9D590")]
		private void OnEnable()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2F9D6A0", Offset = "0x2F9BCA0", VA = "0x182F9D6A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2F9D6F0", Offset = "0x2F9BCF0", VA = "0x182F9D6F0", Slot = "4")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2F9D800", Offset = "0x2F9BE00", VA = "0x182F9D800")]
		public WindGustedParticles()
		{
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem.EmissionModule _emissionModule;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public AnimationCurve _particleIntensityCurve;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x38")]
		private float _currentWindIntensity;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x3C")]
		private float _currentParticleCount;
	}
}
