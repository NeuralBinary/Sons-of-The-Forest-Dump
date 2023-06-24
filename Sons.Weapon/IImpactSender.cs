using System;
using Il2CppDummyDll;
using Sons.Weapon;
using UnityEngine;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
public interface IImpactSender
{
	// Token: 0x06000057 RID: 87
	[Token(Token = "0x6000057")]
	void OnDamageSuccess(DamageNode damageNode, IImpactData impactData);

	// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "1")]
	void OnAttackParried(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "2")]
	void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x0600005A RID: 90
	[Token(Token = "0x600005A")]
	Transform GetRootTransform();

	// Token: 0x0600005B RID: 91
	[Token(Token = "0x600005B")]
	MonoBehaviour GetSourceStimuli();

	// Token: 0x0600005C RID: 92 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
	bool IsThrownLog()
	{
		return default(bool);
	}
}
