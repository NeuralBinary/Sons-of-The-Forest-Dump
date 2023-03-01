using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Attributes;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
[CreateAssetMenu(fileName = "PropDef", menuName = "Sons/Props/Definition", order = 0)]
public class PropDefinition : ScriptableObject
{
	// Token: 0x06000057 RID: 87 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
	public PropDefinition()
	{
	}

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _name;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _prefab;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[TitleFromField("_renderer")]
	private List<MaterialAssignment> _materialAssignments;
}
