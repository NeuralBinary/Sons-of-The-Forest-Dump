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
	// (get) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700000D")]
	public GameObject Flames
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2F70DE0", Offset = "0x2F6F3E0", VA = "0x182F70DE0")]
	private void OnEnable()
	{
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2F71540", Offset = "0x2F6FB40", VA = "0x182F71540")]
	private void OnDisable()
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2F71640", Offset = "0x2F6FC40", VA = "0x182F71640")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2F71850", Offset = "0x2F6FE50", VA = "0x182F71850")]
	private void OnValidate()
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2F718C0", Offset = "0x2F6FEC0", VA = "0x182F718C0")]
	private IEnumerator Burn()
	{
		return null;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2F71950", Offset = "0x2F6FF50", VA = "0x182F71950")]
	public void ReduceFuel(float fuelAmount)
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2F71970", Offset = "0x2F6FF70", VA = "0x182F71970")]
	private void BurnOut()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2F71BA0", Offset = "0x2F701A0", VA = "0x182F71BA0")]
	private void Cleanup()
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2F71C30", Offset = "0x2F70230", VA = "0x182F71C30")]
	private void TrySpread()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2F72540", Offset = "0x2F70B40", VA = "0x182F72540")]
	private IEnumerator ParticleEmissionScale(bool scaleUp)
	{
		return null;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
	private void SetSpreadChance(float spreadChance)
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2F72600", Offset = "0x2F70C00", VA = "0x182F72600")]
	private void UpdateSfx(float fireScale)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2F72780", Offset = "0x2F70D80", VA = "0x182F72780")]
	private void StartSfx()
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2F72910", Offset = "0x2F70F10", VA = "0x182F72910")]
	private void StopSfx()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2F72950", Offset = "0x2F70F50", VA = "0x182F72950")]
	public FireSphere()
	{
	}

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x20")]
	public bool DisableSpread;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _radius;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _burnRate;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool _infiniteFuel;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _totalFuel;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x34")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _spreadChance;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x38")]
	[Range(0f, 10f)]
	[SerializeField]
	private float _minUpdateRate;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Range(0f, 10f)]
	private float _maxUpdateRate;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _spawnAttempts;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _firePrefab;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _fireSpherePrefab;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _growthSpeed;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _maxFireScale;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _characterBurnAmount;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _fireParticleEmissionMultiplier;

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x68")]
	[EventRef]
	[SerializeField]
	public string _fireSfxEvent;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x70")]
	private EventInstance _fireSfx;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem _flameFXParticles;

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x80")]
	private GameObject _flames;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x88")]
	private SphereCollider _sphereCollider;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x90")]
	private bool _isBurntOut;
}
