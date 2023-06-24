using System;
using Ai.AiUtilities;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B5 RID: 1973
	[Token(Token = "0x20007B5")]
	public class PlayerEffects : MonoBehaviour
	{
		// Token: 0x06003542 RID: 13634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003542")]
		[Address(RVA = "0x34DC5D0", Offset = "0x34DABD0", VA = "0x1834DC5D0")]
		private void Start()
		{
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x34DC5F0", Offset = "0x34DABF0", VA = "0x1834DC5F0")]
		private void Update()
		{
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x34DCDB0", Offset = "0x34DB3B0", VA = "0x1834DCDB0")]
		private void UpdateParticlesActive(bool newActive, ref bool oldActive, ParticleSystem[] particleSystems)
		{
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x34DCEE0", Offset = "0x34DB4E0", VA = "0x1834DCEE0")]
		public void ToggleBurningFx(bool onFire)
		{
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x2F67D10", Offset = "0x2F66310", VA = "0x182F67D10")]
		private void DisableFireObject()
		{
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x2921A30", Offset = "0x2920030", VA = "0x182921A30")]
		public void SetActive(bool value)
		{
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x34DD0E0", Offset = "0x34DB6E0", VA = "0x1834DD0E0")]
		public PlayerEffects()
		{
		}

		// Token: 0x04002DE6 RID: 11750
		[Token(Token = "0x4002DE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _activeDistance;

		// Token: 0x04002DE7 RID: 11751
		[Token(Token = "0x4002DE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _onFireEffect;

		// Token: 0x04002DE8 RID: 11752
		[Token(Token = "0x4002DE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04002DE9 RID: 11753
		[Token(Token = "0x4002DE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem[] _waterRipples;

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _requiredSnowDepth;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ParticleSystem[] _snowParticles;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ParticleSystem[] _sandParticles;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _splashEvent;

		// Token: 0x04002DEE RID: 11758
		[Token(Token = "0x4002DEE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _minSpeedForSplash;

		// Token: 0x04002DEF RID: 11759
		[Token(Token = "0x4002DEF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _speedForFullSplash;

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x68")]
		private bool _spawnWaterRipples;

		// Token: 0x04002DF1 RID: 11761
		[Token(Token = "0x4002DF1")]
		[FieldOffset(Offset = "0x69")]
		private bool _spawnSnowTrails;

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x6A")]
		private bool _spawnSandTrails;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x6B")]
		private bool _lastWaterActive;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x6C")]
		private float _lastSplashTime;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x70")]
		private readonly TrackRootVelocity _trackVelocity;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _lastFootPosition;

		// Token: 0x04002DF7 RID: 11767
		[Token(Token = "0x4002DF7")]
		[FieldOffset(Offset = "0x84")]
		private bool _active;
	}
}
