using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class SubmarineCamera : MonoBehaviour
{
	// Token: 0x0600002A RID: 42 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9F6EB0", Offset = "0x9F54B0", VA = "0x1809F6EB0")]
	private void Update()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9F7870", Offset = "0x9F5E70", VA = "0x1809F7870")]
	public SubmarineCamera()
	{
	}

	// Token: 0x04000065 RID: 101
	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform _cameraRoot;

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _cameraTarget;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _cameraTargetPosition;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 _deltaMousePosition;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 _lastMousePosition;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x50")]
	private float _deltaMouseScroll;
}
