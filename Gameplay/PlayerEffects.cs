using System;
using Ai.AiUtilities;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	public class PlayerEffects : MonoBehaviour
	{
		// Token: 0x06002AD2 RID: 10962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD2")]
		[Address(RVA = "0x2DD88E0", Offset = "0x2DD78E0", VA = "0x182DD88E0")]
		private void Start()
		{
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD3")]
		[Address(RVA = "0x2DD8AC0", Offset = "0x2DD7AC0", VA = "0x182DD8AC0")]
		private void Update()
		{
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD4")]
		[Address(RVA = "0x2DD8A30", Offset = "0x2DD7A30", VA = "0x182DD8A30")]
		private void UpdateParticlesActive(bool newActive, ref bool oldActive, ParticleSystem[] particleSystems)
		{
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD5")]
		[Address(RVA = "0x2DD8900", Offset = "0x2DD7900", VA = "0x182DD8900")]
		public void ToggleBurningFx(bool onFire)
		{
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD6")]
		[Address(RVA = "0x299E7F0", Offset = "0x299D7F0", VA = "0x18299E7F0")]
		private void DisableFireObject()
		{
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x2DD91C0", Offset = "0x2DD81C0", VA = "0x182DD91C0")]
		public PlayerEffects()
		{
		}

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _onFireEffect;

		// Token: 0x04002648 RID: 9800
		[Token(Token = "0x4002648")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04002649 RID: 9801
		[Token(Token = "0x4002649")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem[] _waterRipples;

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem[] _snowParticles;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ParticleSystem[] _sandParticles;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0x58")]
		[EventRef]
		[SerializeField]
		private string _splashEvent;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _minSpeedForSplash;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _speedForFullSplash;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0x68")]
		private bool _spawnWaterRipples;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0x69")]
		private bool _spawnSnowTrails;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0x6A")]
		private bool _spawnSandTrails;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0x6B")]
		private bool _lastWaterActive;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x6C")]
		private float _lastSplashTime;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x70")]
		private readonly TrackRootVelocity _trackVelocity;

		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _lastFootPosition;
	}
}
