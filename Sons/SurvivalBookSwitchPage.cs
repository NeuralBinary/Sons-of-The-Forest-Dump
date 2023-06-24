using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025D RID: 605
[Token(Token = "0x200025D")]
[Serializable]
public class SurvivalBookSwitchPage : MonoBehaviour
{
	// Token: 0x060010CC RID: 4300 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x373E710", Offset = "0x373CD10", VA = "0x18373E710", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00006198 File Offset: 0x00004398
	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x373E940", Offset = "0x373CF40", VA = "0x18373E940", Slot = "5")]
	public virtual bool IsOverCollider()
	{
		return default(bool);
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x373EBF0", Offset = "0x373D1F0", VA = "0x18373EBF0", Slot = "6")]
	public virtual void OnMouseOver()
	{
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x373ECF0", Offset = "0x373D2F0", VA = "0x18373ECF0", Slot = "7")]
	public virtual void OnMouseExit()
	{
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x373EDF0", Offset = "0x373D3F0", VA = "0x18373EDF0", Slot = "8")]
	public virtual void Update()
	{
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SurvivalBookSwitchPage()
	{
	}

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyPage;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Pages;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x30")]
	public bool Tab;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Index;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x40")]
	public bool IsIndex;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x44")]
	public Color SwitchColor;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject MyArrow;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000FB2")]
	[FieldOffset(Offset = "0x60")]
	private Material MyMat;
}
