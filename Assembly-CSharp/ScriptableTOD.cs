using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
[CreateAssetMenu(fileName = "TODData", menuName = "ScriptableObjects/SctiptableTOD", order = 1)]
public class ScriptableTOD : ScriptableObject
{
	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public ScriptableTOD()
	{
	}

	// Token: 0x040000EC RID: 236
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve blend;

	// Token: 0x040000ED RID: 237
	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve intensity;

	// Token: 0x040000EE RID: 238
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve ambient;
}
