using System;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x0200024A RID: 586
[Token(Token = "0x200024A")]
public class RainSfx : MonoBehaviour, IWindReceiver
{
	// Token: 0x06001017 RID: 4119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x2CEC6F0", Offset = "0x2CEB6F0", VA = "0x182CEC6F0")]
	private void Awake()
	{
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x2FB6690", Offset = "0x2FB5690", VA = "0x182FB6690")]
	private void OnEnable()
	{
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x2FB66F0", Offset = "0x2FB56F0", VA = "0x182FB66F0")]
	private void PlayInstance()
	{
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101A")]
	[Address(RVA = "0x2FB69E0", Offset = "0x2FB59E0", VA = "0x182FB69E0")]
	private void Update()
	{
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101B")]
	[Address(RVA = "0x2FB68C0", Offset = "0x2FB58C0", VA = "0x182FB68C0")]
	private void UpdateWind()
	{
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101C")]
	[Address(RVA = "0x2FB6600", Offset = "0x2FB5600", VA = "0x182FB6600")]
	private void OnDisable()
	{
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101D")]
	[Address(RVA = "0x2FB69C0", Offset = "0x2FB59C0", VA = "0x182FB69C0", Slot = "4")]
	public void UpdateWind(Vector3 direction, float intensity)
	{
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600101E")]
	[Address(RVA = "0x2FB6CD0", Offset = "0x2FB5CD0", VA = "0x182FB6CD0")]
	public RainSfx()
	{
	}

	// Token: 0x04000F28 RID: 3880
	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x20")]
	public string eventPath;

	// Token: 0x04000F29 RID: 3881
	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _delay;

	// Token: 0x04000F2A RID: 3882
	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0x30")]
	private EventInstance eventInstance;

	// Token: 0x04000F2B RID: 3883
	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x38")]
	private float _triggerTime;

	// Token: 0x04000F2C RID: 3884
	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x3C")]
	private bool _triggered;

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x40")]
	private float _windIntensity;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 _windDirection;
}
