using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000255 RID: 597
[Token(Token = "0x2000255")]
[Serializable]
public class ScriptPlaneLights : MonoBehaviour
{
	// Token: 0x06001039 RID: 4153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001039")]
	[Address(RVA = "0x2FB78E0", Offset = "0x2FB68E0", VA = "0x182FB78E0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103A")]
	[Address(RVA = "0x2FB76F0", Offset = "0x2FB66F0", VA = "0x182FB76F0", Slot = "5")]
	public virtual void LightsChange()
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103B")]
	[Address(RVA = "0x2FB7820", Offset = "0x2FB6820", VA = "0x182FB7820", Slot = "6")]
	public virtual void PulseTv()
	{
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103C")]
	[Address(RVA = "0x2FB7980", Offset = "0x2FB6980", VA = "0x182FB7980", Slot = "7")]
	public virtual void Update()
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103D")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
	public virtual void Lightning()
	{
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103E")]
	[Address(RVA = "0x2FB7880", Offset = "0x2FB6880", VA = "0x182FB7880", Slot = "9")]
	public virtual void SeatBeltLightsOn()
	{
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600103F")]
	[Address(RVA = "0x2296420", Offset = "0x2295420", VA = "0x182296420", Slot = "10")]
	public virtual void Lights1Off()
	{
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001040")]
	[Address(RVA = "0x299E7F0", Offset = "0x299D7F0", VA = "0x18299E7F0", Slot = "11")]
	public virtual void Lights2Off()
	{
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001041")]
	[Address(RVA = "0x2A41F90", Offset = "0x2A40F90", VA = "0x182A41F90", Slot = "12")]
	public virtual void Lights3Off()
	{
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001042")]
	[Address(RVA = "0x2D12490", Offset = "0x2D11490", VA = "0x182D12490", Slot = "13")]
	public virtual void Lights1On()
	{
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x2FB76C0", Offset = "0x2FB66C0", VA = "0x182FB76C0", Slot = "14")]
	public virtual void Lights2On()
	{
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x2A42D10", Offset = "0x2A41D10", VA = "0x182A42D10", Slot = "15")]
	public virtual void Lights3On()
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ScriptPlaneLights()
	{
	}

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject lights1;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject lights2;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject lights3;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x38")]
	public Light LightningLight;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x40")]
	public Renderer TVscreen;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x48")]
	private object Pulse;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x50")]
	public Renderer SeatBeltLights;
}
