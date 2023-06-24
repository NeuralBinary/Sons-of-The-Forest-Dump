using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
[Obsolete("Use DestroyAfter")]
[Serializable]
public class TurnOff : MonoBehaviour
{
	// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110A")]
	[Address(RVA = "0x3687690", Offset = "0x3685C90", VA = "0x183687690", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110B")]
	[Address(RVA = "0x3742F50", Offset = "0x3741550", VA = "0x183742F50")]
	private void Update()
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600110C")]
	[Address(RVA = "0x3743040", Offset = "0x3741640", VA = "0x183743040")]
	public TurnOff()
	{
	}

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("Wait")]
	private int _wait;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x24")]
	private float _timerStart;
}
