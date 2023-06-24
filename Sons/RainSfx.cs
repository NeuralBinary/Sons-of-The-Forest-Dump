using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x02000247 RID: 583
[Token(Token = "0x2000247")]
public class RainSfx : MonoBehaviour, IWindReceiver
{
	// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x3738CE0", Offset = "0x37372E0", VA = "0x183738CE0")]
	private void Awake()
	{
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x3738D20", Offset = "0x3737320", VA = "0x183738D20")]
	private void OnEnable()
	{
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x3738DC0", Offset = "0x37373C0", VA = "0x183738DC0")]
	private void PlayInstance()
	{
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x3739020", Offset = "0x3737620", VA = "0x183739020")]
	private void Update()
	{
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x37390B0", Offset = "0x37376B0", VA = "0x1837390B0")]
	private void UpdateWind()
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x3739360", Offset = "0x3737960", VA = "0x183739360")]
	private void OnDisable()
	{
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001073")]
	[Address(RVA = "0x37393F0", Offset = "0x37379F0", VA = "0x1837393F0", Slot = "4")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x3739410", Offset = "0x3737A10", VA = "0x183739410")]
	public RainSfx()
	{
	}

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x20")]
	public string eventPath;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _delay;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance eventInstance;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x38")]
	private float _triggerTime;

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x3C")]
	private bool _triggered;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x40")]
	private float _windIntensity;

	// Token: 0x04000F59 RID: 3929
	[Token(Token = "0x4000F59")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 _windDirection;
}
