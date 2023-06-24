using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class PlayerWorldPositionFixer : MonoBehaviour
{
	// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x31CB3F0", Offset = "0x31C99F0", VA = "0x1831CB3F0")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x31CB500", Offset = "0x31C9B00", VA = "0x1831CB500")]
	private void OnValidate()
	{
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x31CB810", Offset = "0x31C9E10", VA = "0x1831CB810")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x31CBB50", Offset = "0x31CA150", VA = "0x1831CBB50")]
	private Vector3 CalculateWrappedPosition(Vector3 playerPosition, Vector3 offsetFromEdge)
	{
		return default(Vector3);
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x31CBDF0", Offset = "0x31CA3F0", VA = "0x1831CBDF0")]
	public PlayerWorldPositionFixer()
	{
	}

	// Token: 0x0400030F RID: 783
	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Bounds _bounds;

	// Token: 0x04000310 RID: 784
	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _playerTransform;

	// Token: 0x04000311 RID: 785
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rigidbody _playerRigidbody;

	// Token: 0x04000312 RID: 786
	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _triggerThreshold;

	// Token: 0x04000313 RID: 787
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _minYWhenWrapping;

	// Token: 0x04000314 RID: 788
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x50")]
	private PlayerHangGliderAction _gliderAction;

	// Token: 0x04000315 RID: 789
	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _lastSanitizedPosition;
}
