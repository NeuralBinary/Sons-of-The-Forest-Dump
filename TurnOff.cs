using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000287 RID: 647
[Token(Token = "0x2000287")]
[Obsolete("Use DestroyAfter")]
[Serializable]
public class TurnOff : MonoBehaviour
{
	// Token: 0x060010BC RID: 4284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x2F46EE0", Offset = "0x2F45EE0", VA = "0x182F46EE0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x2FBCEF0", Offset = "0x2FBBEF0", VA = "0x182FBCEF0")]
	private void Update()
	{
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x2FBCF70", Offset = "0x2FBBF70", VA = "0x182FBCF70")]
	public TurnOff()
	{
	}

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[FormerlySerializedAs("Wait")]
	private int _wait;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x24")]
	private float _timerStart;
}
