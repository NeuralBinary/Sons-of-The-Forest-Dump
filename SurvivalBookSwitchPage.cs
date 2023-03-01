using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
[Serializable]
public class SurvivalBookSwitchPage : MonoBehaviour
{
	// Token: 0x0600107E RID: 4222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x2FBA810", Offset = "0x2FB9810", VA = "0x182FBA810", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x2FBA900", Offset = "0x2FB9900", VA = "0x182FBA900", Slot = "5")]
	public virtual bool IsOverCollider()
	{
		return default(bool);
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001080")]
	[Address(RVA = "0x2FBAB30", Offset = "0x2FB9B30", VA = "0x182FBAB30", Slot = "6")]
	public virtual void OnMouseOver()
	{
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001081")]
	[Address(RVA = "0x2FBAAA0", Offset = "0x2FB9AA0", VA = "0x182FBAAA0", Slot = "7")]
	public virtual void OnMouseExit()
	{
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001082")]
	[Address(RVA = "0x2FBABC0", Offset = "0x2FB9BC0", VA = "0x182FBABC0", Slot = "8")]
	public virtual void Update()
	{
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001083")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public SurvivalBookSwitchPage()
	{
	}

	// Token: 0x04000F85 RID: 3973
	[Token(Token = "0x4000F85")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyPage;

	// Token: 0x04000F86 RID: 3974
	[Token(Token = "0x4000F86")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Pages;

	// Token: 0x04000F87 RID: 3975
	[Token(Token = "0x4000F87")]
	[FieldOffset(Offset = "0x30")]
	public bool Tab;

	// Token: 0x04000F88 RID: 3976
	[Token(Token = "0x4000F88")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Index;

	// Token: 0x04000F89 RID: 3977
	[Token(Token = "0x4000F89")]
	[FieldOffset(Offset = "0x40")]
	public bool IsIndex;

	// Token: 0x04000F8A RID: 3978
	[Token(Token = "0x4000F8A")]
	[FieldOffset(Offset = "0x44")]
	public Color SwitchColor;

	// Token: 0x04000F8B RID: 3979
	[Token(Token = "0x4000F8B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject MyArrow;

	// Token: 0x04000F8C RID: 3980
	[Token(Token = "0x4000F8C")]
	[FieldOffset(Offset = "0x60")]
	private Material MyMat;
}
