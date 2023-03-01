using System;
using System.Collections;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
[RequireComponent(typeof(SphereCollider))]
public class FireSphere : MonoBehaviour
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000D")]
	public GameObject Flames
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x68B100", Offset = "0x68A100", VA = "0x18068B100")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x29A6980", Offset = "0x29A5980", VA = "0x1829A6980")]
	private void OnEnable()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x29A68B0", Offset = "0x29A58B0", VA = "0x1829A68B0")]
	private void OnDisable()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x29A6E10", Offset = "0x29A5E10", VA = "0x1829A6E10")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x29A6F50", Offset = "0x29A5F50", VA = "0x1829A6F50")]
	private void OnValidate()
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x29A67E0", Offset = "0x29A57E0", VA = "0x1829A67E0")]
	private IEnumerator Burn()
	{
		return null;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x29A7040", Offset = "0x29A6040", VA = "0x1829A7040")]
	public void ReduceFuel(float fuelAmount)
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x29A66E0", Offset = "0x29A56E0", VA = "0x1829A66E0")]
	private void BurnOut()
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x29A6850", Offset = "0x29A5850", VA = "0x1829A6850")]
	private void Cleanup()
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x29A7240", Offset = "0x29A6240", VA = "0x1829A7240")]
	private void TrySpread()
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x29A6FC0", Offset = "0x29A5FC0", VA = "0x1829A6FC0")]
	private IEnumerator ParticleEmissionScale(bool scaleUp)
	{
		return null;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x5A1850", Offset = "0x5A0850", VA = "0x1805A1850")]
	private void SetSpreadChance(float spreadChance)
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x29A7840", Offset = "0x29A6840", VA = "0x1829A7840")]
	private void UpdateSfx(float fireScale)
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x29A7060", Offset = "0x29A6060", VA = "0x1829A7060")]
	private void StartSfx()
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x29A7200", Offset = "0x29A6200", VA = "0x1829A7200")]
	private void StopSfx()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x29A7920", Offset = "0x29A6920", VA = "0x1829A7920")]
	public FireSphere()
	{
	}

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x20")]
	public bool DisableSpread;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _radius;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _burnRate;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool _infiniteFuel;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _totalFuel;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _spreadChance;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 10f)]
	[SerializeField]
	private float _minUpdateRate;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 10f)]
	private float _maxUpdateRate;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _spawnAttempts;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _firePrefab;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _fireSpherePrefab;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _growthSpeed;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _maxFireScale;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _characterBurnAmount;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _fireParticleEmissionMultiplier;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x68")]
	[EventRef]
	[SerializeField]
	public string _fireSfxEvent;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x70")]
	private EventInstance _fireSfx;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem _flameFXParticles;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x80")]
	private GameObject _flames;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x88")]
	private SphereCollider _sphereCollider;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x90")]
	private bool _isBurntOut;
}
