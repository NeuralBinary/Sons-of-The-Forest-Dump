using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
[AddComponentMenu("Sons/Gameplay/SpringTrap")]
public class SpringTrap : MonoBehaviour
{
	// Token: 0x0600025C RID: 604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2B7F310", Offset = "0x2B7E310", VA = "0x182B7F310")]
	private void OnEnable()
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x2B7F650", Offset = "0x2B7E650", VA = "0x182B7F650")]
	public SpringTrap()
	{
	}

	// Token: 0x0400022D RID: 557
	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SphereCollider _trigger;

	// Token: 0x0400022E RID: 558
	[Token(Token = "0x400022E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask _hitLayerMask;

	// Token: 0x0400022F RID: 559
	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 _force;

	// Token: 0x04000230 RID: 560
	[Token(Token = "0x4000230")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ForceMode _forceMode;

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _playerJumpMultiplier;

	// Token: 0x04000232 RID: 562
	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x40")]
	private FirstPersonCharacter _firstPersonCharacter;

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x48")]
	private float _cachedJumpMultiplier;
}
