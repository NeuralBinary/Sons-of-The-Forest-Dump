using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000252 RID: 594
[Token(Token = "0x2000252")]
[Serializable]
public class ScriptPlaneLights : MonoBehaviour
{
	// Token: 0x0600108F RID: 4239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x373B300", Offset = "0x3739900", VA = "0x18373B300", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x373B3B0", Offset = "0x37399B0", VA = "0x18373B3B0", Slot = "5")]
	public virtual void LightsChange()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x373B510", Offset = "0x3739B10", VA = "0x18373B510", Slot = "6")]
	public virtual void PulseTv()
	{
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x373B6E0", Offset = "0x3739CE0", VA = "0x18373B6E0", Slot = "7")]
	public virtual void Update()
	{
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
	public virtual void Lightning()
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x373B8C0", Offset = "0x3739EC0", VA = "0x18373B8C0", Slot = "9")]
	public virtual void SeatBeltLightsOn()
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x26EAA40", Offset = "0x26E9040", VA = "0x1826EAA40", Slot = "10")]
	public virtual void Lights1Off()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x2F67D10", Offset = "0x2F66310", VA = "0x182F67D10", Slot = "11")]
	public virtual void Lights2Off()
	{
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x3044B70", Offset = "0x3043170", VA = "0x183044B70", Slot = "12")]
	public virtual void Lights3Off()
	{
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x32EF1B0", Offset = "0x32ED7B0", VA = "0x1832EF1B0", Slot = "13")]
	public virtual void Lights1On()
	{
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x373B960", Offset = "0x3739F60", VA = "0x18373B960", Slot = "14")]
	public virtual void Lights2On()
	{
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x3044B10", Offset = "0x3043110", VA = "0x183044B10", Slot = "15")]
	public virtual void Lights3On()
	{
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ScriptPlaneLights()
	{
	}

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x20")]
	public GameObject lights1;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lights2;

	// Token: 0x04000F7A RID: 3962
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject lights3;

	// Token: 0x04000F7B RID: 3963
	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x38")]
	public Light LightningLight;

	// Token: 0x04000F7C RID: 3964
	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x40")]
	public Renderer TVscreen;

	// Token: 0x04000F7D RID: 3965
	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x48")]
	private object Pulse;

	// Token: 0x04000F7E RID: 3966
	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x50")]
	public Renderer SeatBeltLights;
}
