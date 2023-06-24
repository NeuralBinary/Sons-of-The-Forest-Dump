using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[AddComponentMenu("TheForest/Get Axe Position")]
public class GetAxePos : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x3159F50", Offset = "0x3158550", VA = "0x183159F50")]
	private void OnValidate()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
	[Obsolete("Don't use GetAxePosTransform, use GetAxeWorldPosition")]
	public Transform GetAxePosTransform()
	{
		return null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
	public Vector3 GetAxeLocalPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2716C30", Offset = "0x2715230", VA = "0x182716C30")]
	public Vector3 GetAxeWorldPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x29A0850", Offset = "0x299EE50", VA = "0x1829A0850")]
	public void SetAxeLocalPosition(Vector3 position)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
	public bool IsTreeBroken()
	{
		return default(bool);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
	public void SetTreeBroken(bool value)
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x3159F60", Offset = "0x3158560", VA = "0x183159F60")]
	public void Convert()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public GetAxePos()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 _axeLocator;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private Transform axePosTr;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private bool _converted;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x39")]
	private bool _treeBroken;
}
